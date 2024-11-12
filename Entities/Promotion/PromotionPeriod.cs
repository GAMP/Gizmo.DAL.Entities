using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion period entity.
    /// </summary>
    public sealed class PromotionPeriod : PeriodDate
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PromotionPeriod() 
        {
            Days = new HashSet<PromotionPeriodDay>();
        }

        /// <summary>
        /// Gets or sets promotion.
        /// </summary>
        public Promotion Promotion
        {
            get; set;
        }

        /// <summary>
        /// Gets discount period days.
        /// </summary>
        public ISet<PromotionPeriodDay> Days { get; set; }
    }
}
