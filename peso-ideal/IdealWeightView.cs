using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peso_ideal
{
    public partial class IdealWeightView : Form
    {
        public IdealWeightView()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if(!ValidateFields())
            {
                MessageBox.Show("Campos inválidos");
                return;
            }
            double height, weight;
            ValidateHeight(out height);
            ValidateWeight(out weight);
            char gender = rdbtnMale.Checked ? 'M' : 'F';
            double idealWeight = CalculateIdealWeight(height, gender);
            txtIdealWeight.Text = "Peso ideal: " + idealWeight.ToString("N2") + " Kg";
            if(weight > idealWeight)
            {
                MessageBox.Show("Regime Obrigatório Já", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(weight == idealWeight)
            {
                MessageBox.Show("Você está com o peso ideal", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Coma bastante massas e doces", "",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            
        }

        private bool ValidateFields()
        {
            double parseResult;
            bool validHeight = ValidateHeight(out parseResult);
            bool validWeight = ValidateWeight(out parseResult);
            return validHeight && validWeight;
        }

        private bool ValidateHeight(out double height)
        {
            string trueHeightText = mskbxHeight.Text.Replace(" m", "").Replace(".", ",");
            return double.TryParse(trueHeightText, out height);
        }

        private bool ValidateWeight(out double weight)
        {
            string trueWeightText = mskbxWeight.Text.Replace(" Kg", "").Replace(".", ",");
            return double.TryParse(trueWeightText, out weight);
        }

        public double CalculateIdealWeight(double heigth, char gender)
        {
            gender = char.ToLower(gender);
            double multiplier = gender == 'm' ? 72.7 : 62.1;
            double k = gender == 'm' ? 58 : 44.7;
            double weight = (multiplier * heigth) - k;
            return Math.Round(weight, 2);
        }
    }
}
