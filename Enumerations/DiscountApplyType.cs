namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount apply type.
    /// </summary>
    public enum DiscountApplyType
    {
        /// <summary>
        /// Discount is applied to an order line.
        /// </summary>
        OrderLine = 0,

        /// <summary>
        /// Discount is applied to an order.
        /// </summary>
        Order = 1,
    }
}
