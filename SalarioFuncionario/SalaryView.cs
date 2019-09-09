using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SalarioFuncionario
{
    public partial class SalaryView : Form
    {
        public SalaryView()
        {
            InitializeComponent();
        }

        public double InssDiscount(double salary)
        {
            double tax;
            if(salary <= 800.47)
            {
                tax = 0.0765;
            }
            else if(salary <= 1050)
            {
                tax = 0.0865;
            }
            else if(salary <= 1400.77)
            {
                tax = 0.09;
            }
            else if(salary <= 2801.56)
            {
                tax = 0.11;
            }
            else
            {
                return 308.17;
            }
            return Math.Round(salary * tax, 2);
        }

        public double IrpfDiscount(double salary)
        {
            if (salary <= 1257.12)
            {
                return 0;
            }
            double tax = salary <= 2512.08 ? 0.15 : 0.275;
            return Math.Round(salary * tax, 2);
        }

        public double ChildAllowance(double salary, int childCount)
        {
            if(salary <= 435.52)
            {
                return childCount * 22.33;
            }
            if(salary <= 654.61)
            {
                return childCount * 15.74;
            }
            return 0;
        }

        private bool ValidateFields()
        {
            double parseResult = 0;
            bool validName = txtName.Text.Trim() != string.Empty;
            bool validSalary = mskbxSalary.Text.Replace("R$", "").Trim() != string.Empty &&
                ParseValidateField(mskbxSalary, out parseResult);
            return validName && validSalary;
        }

        private bool ParseValidateField(MaskedTextBox field, out double parseResult)
        {
            var style = NumberStyles.AllowCurrencySymbol | NumberStyles.Number;
            var culture = CultureInfo.CurrentCulture;
            return double.TryParse(field.Text, style, culture, out parseResult);
        }

        private void BtnVerifyDiscount_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                System.Media.SystemSounds.Beep.Play();
                lblMessage.Text = "Preencha corretamente todos os campos";
                ClearResultFields();
                return;
            }
            double salary, inss, irpf, childAllowance, netSalary;
            int childCount = (int)numericChildren.Value;

            ParseValidateField(mskbxSalary, out salary);

            inss = InssDiscount(salary);
            irpf = IrpfDiscount(salary);
            childAllowance = ChildAllowance(salary, childCount);
            netSalary = salary - inss - irpf + childAllowance;

            FillResultFields(salary, inss, irpf, childAllowance, netSalary);

            lblMessage.Text = "Os descontos do salário d" + (radbntMale.Checked ? 'o' : 'a')
                + " Sr" + (radbntMale.Checked ? "" : "a") + ". " + txtName.Text + " que é "
                + (chkMarried.Checked ? "casad" : "solteir") + (radbntMale.Checked ? 'o' : 'a')
                + " e que tem " + childCount + " filho(s) são:";
        }

        private void FillResultFields(double salary, double inss, double irpf, 
            double childAllowance, double netSalary)
        {
            if (salary <= 2801.56)
            {
                txtInssTaxRate.Text = ((inss / salary) * 100).ToString("N2") + "%";
            }
            else
            {
                txtInssTaxRate.Text = "11% de R$ 2801,56 (TETO)";
            }
            txtIrpfTaxRate.Text = ((irpf / salary) * 100).ToString("N2") + "%";
            txtInssDiscount.Text = inss.ToString("C");
            txtIrpfDiscount.Text = irpf.ToString("C");
            txtChildAllowance.Text = childAllowance.ToString("C");
            txtNetSalary.Text = netSalary.ToString("C");
        }

        private void ClearResultFields()
        {
            txtInssTaxRate.Text = "";
            txtIrpfTaxRate.Text = "";
            txtInssDiscount.Text = "";
            txtIrpfDiscount.Text = "";
            txtChildAllowance.Text = "";
            txtNetSalary.Text = "";
        }
    }
}
