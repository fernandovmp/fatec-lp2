namespace SalarioFuncionario
{
    partial class SalaryView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblChildrenNumber = new System.Windows.Forms.Label();
            this.grpbxResult = new System.Windows.Forms.GroupBox();
            this.txtIrpfDiscount = new System.Windows.Forms.TextBox();
            this.txtInssDiscount = new System.Windows.Forms.TextBox();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.txtChildAllowance = new System.Windows.Forms.TextBox();
            this.txtIrpfTaxRate = new System.Windows.Forms.TextBox();
            this.txtInssTaxRate = new System.Windows.Forms.TextBox();
            this.lblIrpfDiscount = new System.Windows.Forms.Label();
            this.lblInssDiscount = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblChildAllowance = new System.Windows.Forms.Label();
            this.lblIrpfTaxRate = new System.Windows.Forms.Label();
            this.lblInssTaxRate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskbxSalary = new System.Windows.Forms.MaskedTextBox();
            this.btnVerifyDiscount = new System.Windows.Forms.Button();
            this.numericChildren = new System.Windows.Forms.NumericUpDown();
            this.grpbxGender = new System.Windows.Forms.GroupBox();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.radbntMale = new System.Windows.Forms.RadioButton();
            this.pnlMarried = new System.Windows.Forms.Panel();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpbxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).BeginInit();
            this.grpbxGender.SuspendLayout();
            this.pnlMarried.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do funcionário";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(62, 75);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(89, 17);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salário bruto";
            // 
            // lblChildrenNumber
            // 
            this.lblChildrenNumber.AutoSize = true;
            this.lblChildrenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenNumber.Location = new System.Drawing.Point(36, 105);
            this.lblChildrenNumber.Name = "lblChildrenNumber";
            this.lblChildrenNumber.Size = new System.Drawing.Size(115, 17);
            this.lblChildrenNumber.TabIndex = 2;
            this.lblChildrenNumber.Text = "Número de filhos";
            // 
            // grpbxResult
            // 
            this.grpbxResult.Controls.Add(this.txtIrpfDiscount);
            this.grpbxResult.Controls.Add(this.txtInssDiscount);
            this.grpbxResult.Controls.Add(this.txtNetSalary);
            this.grpbxResult.Controls.Add(this.txtChildAllowance);
            this.grpbxResult.Controls.Add(this.txtIrpfTaxRate);
            this.grpbxResult.Controls.Add(this.txtInssTaxRate);
            this.grpbxResult.Controls.Add(this.lblIrpfDiscount);
            this.grpbxResult.Controls.Add(this.lblInssDiscount);
            this.grpbxResult.Controls.Add(this.lblNetSalary);
            this.grpbxResult.Controls.Add(this.lblChildAllowance);
            this.grpbxResult.Controls.Add(this.lblIrpfTaxRate);
            this.grpbxResult.Controls.Add(this.lblInssTaxRate);
            this.grpbxResult.Location = new System.Drawing.Point(0, 257);
            this.grpbxResult.Name = "grpbxResult";
            this.grpbxResult.Size = new System.Drawing.Size(669, 154);
            this.grpbxResult.TabIndex = 3;
            this.grpbxResult.TabStop = false;
            this.grpbxResult.Text = "Resultado";
            // 
            // txtIrpfDiscount
            // 
            this.txtIrpfDiscount.Enabled = false;
            this.txtIrpfDiscount.Location = new System.Drawing.Point(465, 50);
            this.txtIrpfDiscount.Name = "txtIrpfDiscount";
            this.txtIrpfDiscount.Size = new System.Drawing.Size(180, 20);
            this.txtIrpfDiscount.TabIndex = 15;
            // 
            // txtInssDiscount
            // 
            this.txtInssDiscount.Enabled = false;
            this.txtInssDiscount.Location = new System.Drawing.Point(465, 25);
            this.txtInssDiscount.Name = "txtInssDiscount";
            this.txtInssDiscount.Size = new System.Drawing.Size(180, 20);
            this.txtInssDiscount.TabIndex = 14;
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Enabled = false;
            this.txtNetSalary.Location = new System.Drawing.Point(158, 100);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(180, 20);
            this.txtNetSalary.TabIndex = 13;
            // 
            // txtChildAllowance
            // 
            this.txtChildAllowance.Enabled = false;
            this.txtChildAllowance.Location = new System.Drawing.Point(158, 75);
            this.txtChildAllowance.Name = "txtChildAllowance";
            this.txtChildAllowance.Size = new System.Drawing.Size(180, 20);
            this.txtChildAllowance.TabIndex = 12;
            // 
            // txtIrpfTaxRate
            // 
            this.txtIrpfTaxRate.Enabled = false;
            this.txtIrpfTaxRate.Location = new System.Drawing.Point(158, 50);
            this.txtIrpfTaxRate.Name = "txtIrpfTaxRate";
            this.txtIrpfTaxRate.Size = new System.Drawing.Size(180, 20);
            this.txtIrpfTaxRate.TabIndex = 11;
            // 
            // txtInssTaxRate
            // 
            this.txtInssTaxRate.Enabled = false;
            this.txtInssTaxRate.Location = new System.Drawing.Point(158, 25);
            this.txtInssTaxRate.Name = "txtInssTaxRate";
            this.txtInssTaxRate.Size = new System.Drawing.Size(180, 20);
            this.txtInssTaxRate.TabIndex = 10;
            // 
            // lblIrpfDiscount
            // 
            this.lblIrpfDiscount.AutoSize = true;
            this.lblIrpfDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrpfDiscount.Location = new System.Drawing.Point(357, 50);
            this.lblIrpfDiscount.Name = "lblIrpfDiscount";
            this.lblIrpfDiscount.Size = new System.Drawing.Size(102, 17);
            this.lblIrpfDiscount.TabIndex = 9;
            this.lblIrpfDiscount.Text = "Desconto IRPF";
            // 
            // lblInssDiscount
            // 
            this.lblInssDiscount.AutoSize = true;
            this.lblInssDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInssDiscount.Location = new System.Drawing.Point(356, 25);
            this.lblInssDiscount.Name = "lblInssDiscount";
            this.lblInssDiscount.Size = new System.Drawing.Size(103, 17);
            this.lblInssDiscount.TabIndex = 8;
            this.lblInssDiscount.Text = "Desconto INSS";
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetSalary.Location = new System.Drawing.Point(49, 100);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(102, 17);
            this.lblNetSalary.TabIndex = 7;
            this.lblNetSalary.Text = "Salário Líquido";
            // 
            // lblChildAllowance
            // 
            this.lblChildAllowance.AutoSize = true;
            this.lblChildAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildAllowance.Location = new System.Drawing.Point(51, 75);
            this.lblChildAllowance.Name = "lblChildAllowance";
            this.lblChildAllowance.Size = new System.Drawing.Size(100, 17);
            this.lblChildAllowance.TabIndex = 6;
            this.lblChildAllowance.Text = "Salário Familia";
            // 
            // lblIrpfTaxRate
            // 
            this.lblIrpfTaxRate.AutoSize = true;
            this.lblIrpfTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrpfTaxRate.Location = new System.Drawing.Point(58, 50);
            this.lblIrpfTaxRate.Name = "lblIrpfTaxRate";
            this.lblIrpfTaxRate.Size = new System.Drawing.Size(93, 17);
            this.lblIrpfTaxRate.TabIndex = 5;
            this.lblIrpfTaxRate.Text = "Alíquota IRPF";
            // 
            // lblInssTaxRate
            // 
            this.lblInssTaxRate.AutoSize = true;
            this.lblInssTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInssTaxRate.Location = new System.Drawing.Point(57, 25);
            this.lblInssTaxRate.Name = "lblInssTaxRate";
            this.lblInssTaxRate.Size = new System.Drawing.Size(94, 17);
            this.lblInssTaxRate.TabIndex = 4;
            this.lblInssTaxRate.Text = "Alíquota INSS";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 4;
            // 
            // mskbxSalary
            // 
            this.mskbxSalary.Location = new System.Drawing.Point(158, 75);
            this.mskbxSalary.Mask = "99990.99 $";
            this.mskbxSalary.Name = "mskbxSalary";
            this.mskbxSalary.Size = new System.Drawing.Size(180, 20);
            this.mskbxSalary.TabIndex = 5;
            // 
            // btnVerifyDiscount
            // 
            this.btnVerifyDiscount.Location = new System.Drawing.Point(158, 153);
            this.btnVerifyDiscount.Name = "btnVerifyDiscount";
            this.btnVerifyDiscount.Size = new System.Drawing.Size(180, 38);
            this.btnVerifyDiscount.TabIndex = 8;
            this.btnVerifyDiscount.Text = "Verificar desconto";
            this.btnVerifyDiscount.UseVisualStyleBackColor = true;
            this.btnVerifyDiscount.Click += new System.EventHandler(this.BtnVerifyDiscount_Click);
            // 
            // numericChildren
            // 
            this.numericChildren.Location = new System.Drawing.Point(158, 105);
            this.numericChildren.Name = "numericChildren";
            this.numericChildren.Size = new System.Drawing.Size(44, 20);
            this.numericChildren.TabIndex = 7;
            this.numericChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpbxGender
            // 
            this.grpbxGender.Controls.Add(this.radbtnFemale);
            this.grpbxGender.Controls.Add(this.radbntMale);
            this.grpbxGender.Location = new System.Drawing.Point(383, 45);
            this.grpbxGender.Name = "grpbxGender";
            this.grpbxGender.Size = new System.Drawing.Size(207, 80);
            this.grpbxGender.TabIndex = 9;
            this.grpbxGender.TabStop = false;
            this.grpbxGender.Text = "Sexo";
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Location = new System.Drawing.Point(7, 44);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(67, 17);
            this.radbtnFemale.TabIndex = 1;
            this.radbtnFemale.Text = "Feminino";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            // 
            // radbntMale
            // 
            this.radbntMale.AutoSize = true;
            this.radbntMale.Checked = true;
            this.radbntMale.Location = new System.Drawing.Point(7, 20);
            this.radbntMale.Name = "radbntMale";
            this.radbntMale.Size = new System.Drawing.Size(73, 17);
            this.radbntMale.TabIndex = 0;
            this.radbntMale.TabStop = true;
            this.radbntMale.Text = "Masculino";
            this.radbntMale.UseVisualStyleBackColor = true;
            // 
            // pnlMarried
            // 
            this.pnlMarried.Controls.Add(this.chkMarried);
            this.pnlMarried.Location = new System.Drawing.Point(383, 153);
            this.pnlMarried.Name = "pnlMarried";
            this.pnlMarried.Size = new System.Drawing.Size(200, 100);
            this.pnlMarried.TabIndex = 10;
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(7, 42);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(62, 17);
            this.chkMarried.TabIndex = 0;
            this.chkMarried.Text = "Casado";
            this.chkMarried.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(158, 203);
            this.lblMessage.MaximumSize = new System.Drawing.Size(180, 50);
            this.lblMessage.MinimumSize = new System.Drawing.Size(180, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(180, 50);
            this.lblMessage.TabIndex = 11;
            // 
            // SalaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlMarried);
            this.Controls.Add(this.grpbxGender);
            this.Controls.Add(this.numericChildren);
            this.Controls.Add(this.btnVerifyDiscount);
            this.Controls.Add(this.mskbxSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpbxResult);
            this.Controls.Add(this.lblChildrenNumber);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Name = "SalaryView";
            this.Text = "Salário do funcionário";
            this.grpbxResult.ResumeLayout(false);
            this.grpbxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).EndInit();
            this.grpbxGender.ResumeLayout(false);
            this.grpbxGender.PerformLayout();
            this.pnlMarried.ResumeLayout(false);
            this.pnlMarried.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblChildrenNumber;
        private System.Windows.Forms.GroupBox grpbxResult;
        private System.Windows.Forms.TextBox txtIrpfDiscount;
        private System.Windows.Forms.TextBox txtInssDiscount;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.TextBox txtChildAllowance;
        private System.Windows.Forms.TextBox txtIrpfTaxRate;
        private System.Windows.Forms.TextBox txtInssTaxRate;
        private System.Windows.Forms.Label lblIrpfDiscount;
        private System.Windows.Forms.Label lblInssDiscount;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblChildAllowance;
        private System.Windows.Forms.Label lblIrpfTaxRate;
        private System.Windows.Forms.Label lblInssTaxRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mskbxSalary;
        private System.Windows.Forms.Button btnVerifyDiscount;
        private System.Windows.Forms.NumericUpDown numericChildren;
        private System.Windows.Forms.GroupBox grpbxGender;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.RadioButton radbntMale;
        private System.Windows.Forms.Panel pnlMarried;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.Label lblMessage;
    }
}

