namespace KonversiNilaiGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var textBoxValue = textBoxNilai.Text;

            try
            {
                var value = int.Parse(textBoxValue);
                var grade = "";

                if (value > 80) grade = "A";
                else if (value > 70) grade = "AB";
                else if (value > 65) grade = "B";
                else if (value > 59) grade = "BC";
                else if (value > 55) grade = "C";
                else if (value > 40) grade = "D";
                else grade = "E";

                MessageBox.Show($"Grade : {grade}");

            }
            catch(FormatException ex)
            {
                MessageBox.Show("Value is not an integer!");
            }
        }
    }
}