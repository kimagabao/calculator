using System;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorForm : Form
    {
        private double currentValue = 0;
        private string currentOperation = "";
        private bool isNewNumber = true;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                // If the user starts typing a new number after an operation
                if (isNewNumber)
                {
                    textBoxDisplay.Text = button.Text;
                    isNewNumber = false;
                }
                else
                {
                    // Append to the existing number
                    textBoxDisplay.Text += button.Text;
                }
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (!isNewNumber)
                {
                    // Calculate the result
