namespace tipos_triangulo
{
    partial class TriangleTypeView
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
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.btnTriangleType = new System.Windows.Forms.Button();
            this.lblTriangleType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideA.Location = new System.Drawing.Point(13, 39);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(53, 17);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Lado A";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideB.Location = new System.Drawing.Point(13, 65);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(53, 17);
            this.lblSideB.TabIndex = 1;
            this.lblSideB.Text = "Lado B";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideC.Location = new System.Drawing.Point(12, 93);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(53, 17);
            this.lblSideC.TabIndex = 2;
            this.lblSideC.Text = "Lado C";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(72, 38);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);
            this.txtSideA.TabIndex = 3;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(72, 64);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 20);
            this.txtSideB.TabIndex = 4;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(71, 90);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 20);
            this.txtSideC.TabIndex = 5;
            // 
            // btnTriangleType
            // 
            this.btnTriangleType.Location = new System.Drawing.Point(56, 126);
            this.btnTriangleType.Name = "btnTriangleType";
            this.btnTriangleType.Size = new System.Drawing.Size(94, 38);
            this.btnTriangleType.TabIndex = 6;
            this.btnTriangleType.Text = "Tipo do Triângulo";
            this.btnTriangleType.UseVisualStyleBackColor = true;
            this.btnTriangleType.Click += new System.EventHandler(this.BtnTriangleType_Click);
            // 
            // lblTriangleType
            // 
            this.lblTriangleType.AutoSize = true;
            this.lblTriangleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTriangleType.Location = new System.Drawing.Point(190, 38);
            this.lblTriangleType.MaximumSize = new System.Drawing.Size(150, 73);
            this.lblTriangleType.MinimumSize = new System.Drawing.Size(150, 73);
            this.lblTriangleType.Name = "lblTriangleType";
            this.lblTriangleType.Size = new System.Drawing.Size(150, 73);
            this.lblTriangleType.TabIndex = 7;
            // 
            // TriangleTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 176);
            this.Controls.Add(this.lblTriangleType);
            this.Controls.Add(this.btnTriangleType);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.MaximumSize = new System.Drawing.Size(394, 215);
            this.Name = "TriangleTypeView";
            this.Text = "Tipo do triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnTriangleType;
        private System.Windows.Forms.Label lblTriangleType;
    }
}

