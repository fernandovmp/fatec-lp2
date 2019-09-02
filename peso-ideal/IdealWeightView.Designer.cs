namespace peso_ideal
{
    partial class IdealWeightView
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.grpbGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.mskbxHeight = new System.Windows.Forms.MaskedTextBox();
            this.mskbxWeight = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtIdealWeight = new System.Windows.Forms.TextBox();
            this.grpbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(13, 58);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(45, 17);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Altura";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(13, 84);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 17);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Peso";
            // 
            // grpbGender
            // 
            this.grpbGender.Controls.Add(this.rdbtnFemale);
            this.grpbGender.Controls.Add(this.rdbtnMale);
            this.grpbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbGender.Location = new System.Drawing.Point(192, 58);
            this.grpbGender.Name = "grpbGender";
            this.grpbGender.Size = new System.Drawing.Size(105, 74);
            this.grpbGender.TabIndex = 2;
            this.grpbGender.TabStop = false;
            this.grpbGender.Text = "Sexo";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(7, 44);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(83, 21);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Feminino";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(7, 20);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(89, 21);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Masculino";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // mskbxHeight
            // 
            this.mskbxHeight.Location = new System.Drawing.Point(65, 58);
            this.mskbxHeight.Mask = "0,00 m";
            this.mskbxHeight.Name = "mskbxHeight";
            this.mskbxHeight.Size = new System.Drawing.Size(100, 20);
            this.mskbxHeight.TabIndex = 3;
            // 
            // mskbxWeight
            // 
            this.mskbxWeight.Location = new System.Drawing.Point(65, 84);
            this.mskbxWeight.Mask = "990,99 Kg";
            this.mskbxWeight.Name = "mskbxWeight";
            this.mskbxWeight.Size = new System.Drawing.Size(100, 20);
            this.mskbxWeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(65, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtIdealWeight
            // 
            this.txtIdealWeight.Enabled = false;
            this.txtIdealWeight.Location = new System.Drawing.Point(65, 150);
            this.txtIdealWeight.Name = "txtIdealWeight";
            this.txtIdealWeight.Size = new System.Drawing.Size(232, 20);
            this.txtIdealWeight.TabIndex = 6;
            // 
            // IdealWeightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 280);
            this.Controls.Add(this.txtIdealWeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.mskbxWeight);
            this.Controls.Add(this.mskbxHeight);
            this.Controls.Add(this.grpbGender);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.MaximumSize = new System.Drawing.Size(384, 319);
            this.Name = "IdealWeightView";
            this.Text = "Peso Ideal";
            this.grpbGender.ResumeLayout(false);
            this.grpbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox grpbGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.MaskedTextBox mskbxHeight;
        private System.Windows.Forms.MaskedTextBox mskbxWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtIdealWeight;
    }
}

