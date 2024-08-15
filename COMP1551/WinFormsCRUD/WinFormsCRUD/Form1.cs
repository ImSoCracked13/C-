namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void minButton_Click(object sender, EventArgs e)
            {
                // Parse input values
                if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
                {
                    // Check for min
                    int min = Math.Min(num1, num2);
                    MessageBox.Show($"Minimum value: {min}", "Min Check");
                }
                else
                {
                    MessageBox.Show("Please enter valid integer values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void maxButton_Click(object sender, EventArgs e)
            {
                // Parse input values
                if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
                {
                    // Check for max
                    int max = Math.Max(num1, num2);
                    MessageBox.Show($"Maximum value: {max}", "Max Check");
                }
                else
                {
                    MessageBox.Show("Please enter valid integer values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
