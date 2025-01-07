namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product order line reservation fee.
    /// </summary>
    public sealed class ProductOLReservationFee : ProductOL
    {
        /// <summary>
        /// Gets or sets fee type.
        /// </summary>
        public FeeType Type { get; set; }

        /// <summary>
        /// Gets or sets fee value.
        /// </summary>
        public decimal Fee { get; set; }
    }
}
