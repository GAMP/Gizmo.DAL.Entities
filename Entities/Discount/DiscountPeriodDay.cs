using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount period day entity.
    /// </summary>
    public sealed class DiscountPeriodDay : PeriodDay
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountPeriodDay()
        {
            Times = new HashSet<DiscountPeriodDayTime>();
        }

        /// <summary>
        /// Gets or sets discount period id.
        /// </summary>
        public int DiscountPeriodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public DiscountPeriod Period
        {
            get; set;
        }

        /// <summary>
        /// Gets discount period day times.
        /// </summary>
        public ISet<DiscountPeriodDayTime> Times { get; set; }
    }
}
