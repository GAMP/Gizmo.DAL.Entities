namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion period entity.
    /// </summary>
    public sealed class PromotionPeriod : PeriodDate
    {
        /// <summary>
        /// Gets or sets promotion.
        /// </summary>
        public Promotion Promotion
        {
            get; set;
        }
    }
}
