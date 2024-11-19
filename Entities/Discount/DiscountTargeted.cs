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
        /// Gets target groups.
        /// </summary>
        public ISet<TargetGroup> TargetGroups { get; private set; }
    }
}
