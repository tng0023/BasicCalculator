using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;   //initialize numbers and operations
        String operationPerform = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e) //button operation click for numbers
        {
            if ((txtResult.Text == "0") || (isOperationPerformed))
                txtResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")  //checks for decimal
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;
            }
            else if (button.Text == "+/-") //checks for sign button clicked
            {
                double value = Convert.ToDouble(txtResult.Text);
                value = value * -1;
                txtResult.Text = value.ToString();
            }
            else
                txtResult.Text = txtResult.Text + button.Text;
        }
        private void operator_click(object sender, EventArgs e) //button click for operator
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                operationPerform = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerform;
                isOperationPerformed = true;
            }
            else
            {
                operationPerform = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerform;
                isOperationPerformed = true;
            }
        }
        private void btn_clear_Click(object sender, EventArgs e) //clears all entries
        {
            txtResult.Text = "0";
            resultValue = 0;
        }
        private void button21_Click(object sender, EventArgs e) //equation for operator button clicked utilizing Calculator Class
        {
            Calculator.EqualsAnswer(operationPerform, txtResult, resultValue);
            resultValue = Double.Parse(txtResult.Text);
            labelCurrentOperation.Text = "";
            isOperationPerformed = true;
        }

        private void btn_back_Click(object sender, EventArgs e) //back button for most recent number clicked
        {
            Calculator.BackButton(txtResult); //calculator method for back button
        }
      }
}

