namespace ClassExampleModels
{
    /// <summary>
    /// Model class representing a Receive.
    /// </summary>
    public class Receive
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id => this.GetHashCode();

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; } = new Customer();

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public Direction Direction { get; set; } = new Direction();

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

        /// <summary>
        /// Gets or sets the tax percentage.
        /// </summary>
        /// <value>
        /// The tax percentage.
        /// </value>
        public int TaxPercentage { get; set; } = 13;

        /// <summary>
        /// Gets the total amount.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalAmount()
        {
            var total = 0m;
            foreach (var product in this.Products)
            {
                total += product.Price * product.Quantity;
            }

            return total;
        }
    }
}
