using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount targeted entity.
    /// </summary>
    public abstract class DiscountTargeted : DiscountPeriodic
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountTargeted()
        {
            TargetGroups = new HashSet<TargetGroup>();
        }

        /// <summary>
        /// Apply type, basically at what level discount is applied (order or order line)
        /// </summary>
        public DiscountApplyType ApplyType { get; set; }

        /// <summary>
        /// Gets or sets calculation type.
        /// </summary>
        public DiscountCalculationType CalculationType { get; set; }

        /// <summary>
        /// Gets target groups.
        /// </summary>
        public ISet<TargetGroup> TargetGroups { get; private set; }
    }
}
