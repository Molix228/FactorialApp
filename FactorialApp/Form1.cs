using System.Text;

namespace FactorialApp
{
    public partial class FactorialApp : Form
    {
        public FactorialApp()
        {
            InitializeComponent();
        }

       private void btnCalculate_Click(object sender, EventArgs e)
       {
            int n;
            if (int.TryParse(txtInput.Text, out n)) {
                try
                {
                    var (factorial, expression) = CalculateFactorial(n);
                    txtResult.Text = $"{n}! = {expression} = {factorial}";
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please, enter a correct number!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       }

        private (long, string) CalculateFactorial(int n) {

            if (n < 0) {
                throw new ArgumentException("Number cannot be negative");
            }

            long result = 1;

            StringBuilder expression = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
                expression.Append(i);
                if (i < n)
                {
                    expression.Append(" x ");
                }
            }
            return (result, expression.ToString());
        }

        /* private void AdjustTextBoxHeight()
        {
            int lines = txtInput.Lines.Length;
            int newWidth = txtInput.Size.Width;
            int newHeight = txtInput.Size.Height + lines + 5;
            txtInput.Size = new Size(newWidth, newHeight);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            AdjustTextBoxHeight();
        } */
    }
}
