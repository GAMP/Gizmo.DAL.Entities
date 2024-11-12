using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion period day entity.
    /// </summary>
    public sealed class PromotionPeriodDay : PeriodDay
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PromotionPeriodDay()
        {
            Times = new HashSet<PromotionPeriodDayTime>();
        }

        /// <summary>
        /// Gets or sets discount period id.
        /// </summary>
        public int PromotionPeriodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public PromotionPeriod Period
        {
            get; set;
        }

        /// <summary>
        /// Gets discount period day times.
        /// </summary>
        public ISet<PromotionPeriodDayTime> Times { get; set; }
    }
}
