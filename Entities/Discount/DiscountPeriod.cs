using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount period map.
    /// </summary>
    public sealed class DiscountPeriod : PeriodDate
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountPeriod()
        {
            Days = new HashSet<DiscountPeriodDay>();
        }

        /// <summary>
        /// Gets discount period days.
        /// </summary>
        public ISet<DiscountPeriodDay> Days { get; set; }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public Discount Discount { get; set; }
    }
}
