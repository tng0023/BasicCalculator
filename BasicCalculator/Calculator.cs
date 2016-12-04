using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    class Calculator
    {
        public static void EqualsAnswer(String operationPerform, TextBox txtResult, Double resultValue)
        {
            switch (operationPerform)
            {
                case "+":
                    txtResult.Text = (resultValue + Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "sqrt":
                    txtResult.Text = (Math.Sqrt(resultValue)).ToString();
                    break;
                case "1/X":
                    txtResult.Text = (1 / resultValue).ToString(); /*Double.Parse(txtResult.Text).ToString();*/
                    break;
                default:
                    break;
            }
        }
        public static void BackButton(TextBox txtResult)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            if (txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
            }
        }
    }
}
