using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace tipos_triangulo
{
    public enum NumericInputMode { None, Decimal, Digit }
    class NumericTextBox : TextBox
    {
        const NumberStyles validNumberStyles = NumberStyles.AllowDecimalPoint |
                                              NumberStyles.AllowLeadingSign;
        public NumericTextBox() : base()
        {
            InputMode = NumericInputMode.Decimal;
            OnlyPositiveNumbers = false;
            DecimalPlaces = null;
        }

        public NumericInputMode InputMode { get; set; }
        public bool OnlyPositiveNumbers { get; set; }
        public int? DecimalPlaces { get; set; }
        
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!IsValidInput(GetText(" ")))
                {
                    e.Handled = true;
                }
            }
        }

        private string GetText(string input)
        {
            if (Text.Length < SelectionStart)
                SelectionStart = Text.Length;
            int selectionLenght = SelectionLength;
            if (Text.Length < SelectionStart + selectionLenght)
                selectionLenght = Text.Length - SelectionStart;
            string realText = Text.Remove(SelectionStart, selectionLenght);

            int caretIndex = SelectionStart;
            if (realText.Length < caretIndex)
            {
                caretIndex = realText.Length;
            }

            string text = realText.Insert(caretIndex, input);
            return text;
        }

        private bool IsValidInput(string input)
        {
            switch (InputMode)
            {
                case NumericInputMode.None:
                    return true;
                case NumericInputMode.Decimal:
                    return CheckIsDecimal(input);
                case NumericInputMode.Digit:
                    return CheckIsDigit(input);
                default:
                    throw new ArgumentException("Unknow NumericInputMode");
            }
        }

        private bool CheckIsDigit(string input)
        {
            return input.All(char.IsDigit);
        }

        private bool CheckIsDecimal(string input)
        {
            char decimalSeparator = Convert.ToChar(NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            char thousandSeparator = Convert.ToChar(NumberFormatInfo.CurrentInfo.NumberGroupSeparator);
            if (input.Contains(thousandSeparator))
            {
                return false;
            }
            if (input.ToCharArray().Where(c => c == decimalSeparator).Count() > 1)
            {
                return false;
            }

            if(input.Contains(decimalSeparator) && DecimalPlaces != null)
            {
                string decimalPart = input.Substring(input.IndexOf(decimalSeparator));
                if (decimalPart.Length > DecimalPlaces) return false;
            }

            if (input.Contains("-"))
            {
                if (OnlyPositiveNumbers)
                    return false;
                if (input.IndexOf("-", StringComparison.Ordinal) > 0)
                    return false;
                if (input.Length == 1)
                    return true;
            }
            return decimal.TryParse(input, validNumberStyles, CultureInfo.CurrentCulture, out decimal d);
        }

    }
}
