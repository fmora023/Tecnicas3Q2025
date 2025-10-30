using ClassExampleController;
using ClassExampleController.Abstractions;

namespace ClassExamples
{
    /// <summary>
    /// View for Calculator.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CalculatorFrm : Form
    {
        private readonly IOperationsHandler operationsHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorFrm"/> class.
        /// </summary>
        /// <param name="operationsHandler">The operations handler.</param>
        public CalculatorFrm(IOperationsHandler operationsHandler)
        {
            InitializeComponent();
            this.operationsHandler = operationsHandler;
        }

        /// <summary>
        /// Handles the Click event of the Button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var value1 = ArgumentValidator.ParseStringToInt(this.textBox1.Text);
                var value2 = this.textBox2.Text.ParseStringToInt();

                var result = this.operationsHandler.ExecuteOperation(value1, value2, Operations.Add);
                this.lblResult.Text = result.ToString();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                this.lblResult.Text = "Error";
            }

        }
    }
}
