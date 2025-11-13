using ClassExampleController;
using ClassExampleController.Abstractions;
using ClassExampleModels;

namespace ClassExamples
{
    /// <summary>
    /// View for Calculator.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CalculatorFrm : Form
    {
        private readonly IOperationsHandler operationsHandler;

        private readonly UserHandler userHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorFrm"/> class.
        /// </summary>
        /// <param name="operationsHandler">The operations handler.</param>
        public CalculatorFrm(IOperationsHandler operationsHandler, UserHandler userHandler)
        {
            InitializeComponent();
            this.operationsHandler = operationsHandler;
            this.userHandler = userHandler;
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

        private void btnReceive_Click(object sender, EventArgs e)
        {
            // Recuerden el single responsibility principle. Esto deberia pasar por un controller/servicio 
            // que se encargue de crear el receive.
            var client = this.textBox1.Text != string.Empty && int.TryParse(this.textBox1.Text, out var clientNumber) ? clientNumber : 0;
            var products = new List<Product>()
            {
                new()
                {
                    Measure = Measure.Units,
                    Price = 10,
                    ProductName = "Sandias",
                    Producer = "Josue",
                    Quantity = 2,
                },
                new()
                {
                    Measure = Measure.Kilograms,
                    Price = 1000,
                    ProductName = "Tomate",
                    Producer = "Edwin",
                    Quantity = 4,
                },
                new()
                {
                    Measure = Measure.Liters,
                    Price = 1500,
                    ProductName = "Fresco de frutas",
                    Producer = "Allison",
                    Quantity = 2,
                },
            };
            

            var receive = new Receive()
            {
                Customer = this.userHandler.Custumers[client],
                Date = DateTime.Now,
                Direction = new Direction(),
                PaymentMethod = PaymentMethod.CreditCard,
                TaxPercentage = 10,
                Products = products
            };

            var receiveForm = new ReceiveView(receive);
            receiveForm.Show(this);
        }
    }
}
