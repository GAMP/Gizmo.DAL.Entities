namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount periodic map.
    /// </summary>
    public abstract class DiscountPeriodic : Discount
    {
        /// <summary>
        /// Gets or sets discount period.
        /// </summary>
        public DiscountPeriod Period { get; set; }
    }
}
