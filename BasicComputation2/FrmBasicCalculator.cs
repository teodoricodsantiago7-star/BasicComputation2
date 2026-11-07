using CalculatorPrivateAssembly;
namespace BasicComputation2
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result;

            if (!float.TryParse(txtFirstNum.Text, out num1) ||
                !float.TryParse(txtSecondNum.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            switch (cmbOperation.Text)
            {
                case "+":
                    result = BasicComputation.Addition(num1, num2);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(num1, num2);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = BasicComputation.Division(num1, num2);
                    break;
                default:
                    return;
            }

            lblResult.Text = result.ToString();
        }
    }
}
