using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;
using CalculatorDependency;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Variables for storage across calculations.
        Double resultValue = 0.0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((txtResult.Text == "0") || (isOperationPerformed))
            {
                txtResult.Clear();
            }

            isOperationPerformed = false;
            Button btnInput = (Button)sender;
            if(btnInput.Text == ".")
            {
                if(!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + btnInput.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + btnInput.Text;
            }
           
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btnInput = (Button)sender;

            if(resultValue != 0)
            {
                btnEquals.PerformClick();
            }

            operationPerformed = btnInput.Text;
            resultValue = Double.Parse(txtResult.Text);
            lblPending.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void BtnCe_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            CalculatorLibrary.Class1 dllRef = new CalculatorLibrary.Class1();

            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = dllRef.AddNumbers(resultValue, double.Parse(txtResult.Text)).ToString();
                    break;

                case "-":
                    txtResult.Text = dllRef.SubtractNumbers(resultValue, double.Parse(txtResult.Text)).ToString();
                    break;

                case "*":
                    txtResult.Text = dllRef.MultiplyNumbers(resultValue, double.Parse(txtResult.Text)).ToString();
                    break;

                case "/":
                    txtResult.Text = dllRef.DivideNumbers(resultValue, double.Parse(txtResult.Text)).ToString();
                    break;

                default:
                    break;
            }

            resultValue = Double.Parse(txtResult.Text);
            lblPending.Text = "";
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            CalculatorDependency.Class1 InfoMessage = new CalculatorDependency.Class1();
            MessageBox.Show(InfoMessage.ClearMessage());
        }
    }
}
