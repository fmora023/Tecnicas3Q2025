namespace ClassExampleModels
{
    /// <summary>
    /// Model to represent a Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; } = 0;

        /// <summary>
        /// Gets or sets the measure.
        /// </summary>
        /// <value>
        /// The measure.
        /// </value>
        public Measure Measure { get; set; } = Measure.Units;

        /// <summary>
        /// Gets or sets the producer.
        /// </summary>
        /// <value>
        /// The producer.
        /// </value>
        public string Producer { get; set; } = string.Empty;
    }
}