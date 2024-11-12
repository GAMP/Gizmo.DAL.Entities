namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion limit entity.
    /// </summary>
    public sealed class PromotionLimit
    {
        /// <summary>
        /// Gets or sets promotion id.
        /// </summary>
        public int PromotionId { get; set; }

        /// <summary>
        /// Gets or sets promotion limit type.
        /// </summary>
        public PromotionLimitType Type { get; set; }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets promotion.
        /// </summary>
        public Promotion Promotion { get; set; }
    }
}
