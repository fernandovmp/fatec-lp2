using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipos_triangulo
{
    public enum TriangleType { Equilateral, Isosceles, Scalene, None }
    public partial class TriangleTypeView : Form
    {
        public TriangleTypeView()
        {
            InitializeComponent();
        }

        public TriangleType TypeOfTriangle(double sideA, double sideB, double sideC)
        {
            List<double> sides = new List<double>
            {
                sideA,
                sideB,
                sideC
            };
            sides.Sort((a, b) => -1 * a.CompareTo(b));
            if (sides[0] >= sides[1] + sides[2])
            {
                return TriangleType.None;
            }
            if (sides[0] == sides[1] && sides[0] == sides[2])
            {
                return TriangleType.Equilateral;
            }
            if(sides[0] == sides[1] ^ sides[0] == sides[2] ^  sides[1] == sides[2])
            {
                return TriangleType.Isosceles;
            }
            return TriangleType.Scalene;
            
        }

        private void BtnTriangleType_Click(object sender, EventArgs e)
        {
            if(!ValidateFields())
            {
                MessageBox.Show("Campos inválidos!\nPreencha os campos com apenas números");
                return;
            }
            double sideA, sideB, sideC;
            ValidateSide(txtSideA, out sideA);
            ValidateSide(txtSideB, out sideB);
            ValidateSide(txtSideC, out sideC);
            TriangleType triangleType = TypeOfTriangle(sideA, sideB, sideC);
            if(triangleType == TriangleType.Equilateral)
            {
                lblTriangleType.Text = "O tipo desse triângulo é Equilatero!";
                return;
            }
            if(triangleType == TriangleType.Isosceles)
            {
                lblTriangleType.Text = "O tipo desse triângulo é Isosceles!";
                return;
            }
            if(triangleType == TriangleType.Scalene)
            {
                lblTriangleType.Text = "O tipo desse triângulo é Escaleno!";
                return;
            }

            lblTriangleType.Text = "Esses lados não formam um triângulo!";
        }

        private bool ValidateFields()
        {
            double parseResult;
            bool validSideA = ValidateSide(txtSideA, out parseResult);
            bool validSideB = ValidateSide(txtSideB, out parseResult);
            bool validSideC = ValidateSide(txtSideC, out parseResult);
            return validSideA && validSideB && validSideC;
        }

        private bool ValidateSide(TextBox sideField, out double side)
        {
            return double.TryParse(sideField.Text, out side) && sideField.Text.Trim() != string.Empty;
        }
    }
}
