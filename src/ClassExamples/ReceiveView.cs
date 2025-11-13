using ClassExampleModels;

namespace ClassExamples
{
    /// <summary>
    /// View for a Receive.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReceiveView : Form
    {
        private Receive Receive { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiveView"/> class.
        /// </summary>
        /// <param name="receive">The receive.</param>
        public ReceiveView(Receive receive)
        {
            InitializeComponent();
            this.Receive = receive;

            this.FillReceive();
        }

        private void FillReceive()
        {
            this.lblClientName.Text = $"{this.Receive.Customer.Name} {this.Receive.Customer.LastName}";
            this.lblDate.Text = this.Receive.Date.ToString("dd/MM/yyyy");
            this.lblPayment.Text = this.Receive.PaymentMethod.ToString();
            this.lblTotals.Text = $"${this.Receive.GetTotalAmount()}";

            this.lvwProducts.Items.Clear();
            this.lvwProducts.Columns.Clear();
            this.lvwProducts.Columns.AddRange(
                new ColumnHeader() { Text = "Product", Width = 200 },
                new ColumnHeader() { Text = "Price", Width = 100 },
                new ColumnHeader() { Text = "Quantity", Width = 100 },
                new ColumnHeader() { Text = "Producer", Width = 100 }
            );

            foreach (var product in this.Receive.Products)
            {
                var item = new ListViewItem(product.ProductName);
                item.SubItems.Add($"${product.Price}");
                item.SubItems.Add($"{product.Quantity} {product.Measure}");
                item.SubItems.Add(product.Producer);
                this.lvwProducts.Items.Add(item);
            }
        }
    }
}
