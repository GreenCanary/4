namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure the inputs are valid numbers
            if (!double.TryParse(in1.Text, out double num1) || !double.TryParse(in2.Text, out double num2))
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform the selected operation
            string operation = ChooseOpperation.SelectedItem?.ToString();
            double result = 0;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }


                output.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
