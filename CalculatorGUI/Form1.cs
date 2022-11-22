namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOperator.Items.Add("+");
            comboBoxOperator.Items.Add("-");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            var firstNumber = int.Parse(leftOperatorTextBox.Text);
            var secondNumber = int.Parse(rightOperatorTextBox.Text);
            var opr = comboBoxOperator.Text;
            var result = 0;
            switch (opr)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                default:
                    return;
            }

            resultLabel.Text = result.ToString();
        }
    }


}