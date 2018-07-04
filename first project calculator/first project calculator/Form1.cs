using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = secondValue + firstValue;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void operations(object sender, EventArgs e)
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
private void oneoperations(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string operation = ((Button)sender).Name;
            ICalculatorOneArguments calculator = CalculateOneFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }
    }
}
