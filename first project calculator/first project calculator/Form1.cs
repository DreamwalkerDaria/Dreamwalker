using System;
using System.Windows.Forms;
using first_project_calculator.OneArgument;
using first_project_calculator.TwoArgument;

namespace first_project_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operations(object sender, EventArgs e)
        {
            try
            {
                string firstArgumentText = textBox1.Text;
                double firstArgument = Convert.ToDouble(firstArgumentText);
                string secondArgumentText = textBox2.Text;
                double secondArgument = Convert.ToDouble(secondArgumentText);
                string operation = ((Button)sender).Name;
                ICalculatorTwoArguments calculator = CalculateTwoFactory.CreateCalculator(operation);
                double result = calculator.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                textBox3.Text = exc.Message;
            }
        }
        private void oneoperations(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            var firstValue = Convert.ToDouble(firstValueText);
            string operation = ((Button)sender).Name;
            ICalculatorOneArguments calculator = CalculateOneFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }
    }
}
