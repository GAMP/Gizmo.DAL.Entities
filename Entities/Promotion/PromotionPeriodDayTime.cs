namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion period day time entity.
    /// </summary>
    public sealed class PromotionPeriodDayTime : PeriodDayTime
    {
        /// <summary>
        /// Gets or sets period day id.
        /// </summary>
        public int PromotionPeriodDayId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets time period day.
        /// </summary>
        public PromotionPeriodDay Day
        {
            get; set;
        }
    }
}
