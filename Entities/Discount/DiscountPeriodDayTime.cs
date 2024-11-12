namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount period day time.
    /// </summary>
    public sealed class DiscountPeriodDayTime : PeriodDayTime
    {
        /// <summary>
        /// Gets or sets period day id.
        /// </summary>
        public int DiscountPeriodDayId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets time period day.
        /// </summary>
        public DiscountPeriodDay Day
        {
            get; set;
        }
    }
}
