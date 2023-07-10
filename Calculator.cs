/*
 * Created by Rider
 * User: zOmArRD
 */

using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private double _firstNumber = 0, _secondNumber = 0;
        
        private char _operation;
        
        public Calculator()
        {
            InitializeComponent();
        }

        /**
         * This method adds the number to the resultBox
         * And if the resultBox has a 0, nothing will be added.
         */
        private void AddNumber(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            if (resultBox.Text == @"0")
            {
                resultBox.Text = "";
            }

            resultBox.Text += btn.Text;
        }
        
        /**
         * Button for remove the last number
         */
        private void RemoveLastNumber(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text.Length > 1 ? resultBox.Text.Remove(resultBox.Text.Length - 1) : @"0";
        }
        
        /**
         * Button for CE
         */
        private void Clear(object sender, EventArgs e)
        {
            resultBox.Text = @"0";
        }
        
        /**
         * Button for C
         */
        private void ClearAll(object sender, EventArgs e)
        {
            resultBox.Text = @"0";
            _firstNumber = 0;
            _secondNumber = 0;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            _firstNumber = Convert.ToDouble(resultBox.Text);
            _operation = Convert.ToChar(btn.Tag);
            resultBox.Text = @"0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            _secondNumber = Convert.ToDouble(resultBox.Text);

            switch (_operation)
            {
                case '+':
                    resultBox.Text = (_firstNumber + _secondNumber).ToString(CultureInfo.InvariantCulture);
                    break;
                case '−':
                    resultBox.Text = (_firstNumber - _secondNumber).ToString(CultureInfo.InvariantCulture);
                    break;
                case '×':
                    resultBox.Text = (_firstNumber * _secondNumber).ToString(CultureInfo.InvariantCulture);
                    break;
                case '÷':
                    resultBox.Text = (_firstNumber / _secondNumber).ToString(CultureInfo.InvariantCulture);
                    break;
            }
            
            _firstNumber = Convert.ToDouble(resultBox.Text);
        }
    }
}