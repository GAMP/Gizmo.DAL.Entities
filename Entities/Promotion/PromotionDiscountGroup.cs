namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion discount group entity.
    /// </summary>
    /// <remarks>
    /// Promotion that targets discount group.
    /// </remarks>
    public sealed class PromotionDiscountGroup : Promotion
    {
        /// <summary>
        /// Gets or sets discount group id.
        /// </summary>
        public int DiscountGroupId { get; set; }

        /// <summary>
        /// Gets or sets discount group.
        /// </summary>
        public DiscountGroup DiscountGroup { get; set; }
    }
}
