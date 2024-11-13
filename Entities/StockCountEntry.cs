namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count entry entity.
    /// </summary>
    public sealed class StockCountEntry : CreatedByOperatorBase
    {
        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets stock count id.
        /// </summary>
        public int StockCountId { get; set; }

        /// <summary>
        /// Gets or sets expected value.
        /// </summary>
        public decimal Expected { get; set; }

        /// <summary>
        /// Gets or sets actual value.
        /// </summary>
        public decimal Actual { get; set; }

        /// <summary>
        /// Gets or sets stock count.
        /// </summary>
        public StockCount StockCount { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public ProductBase Product { get; set; }
    }
}
