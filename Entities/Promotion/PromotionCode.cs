namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion code entity.
    /// </summary>
    public sealed class PromotionCode : ModifiableByOperatorBase
    {
        /// <summary>
        /// Gets or sets promotion code value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets promotion id.
        /// </summary>
        public int PromotionId { get; set; }

        /// <summary>
        /// Gets or sets promotion code status.
        /// </summary>
        public PromotionCodeStatus Status { get; set; }

        /// <summary>
        /// Gets promotion.
        /// </summary>
        public Promotion Promotion { get; set; }
    }
}
