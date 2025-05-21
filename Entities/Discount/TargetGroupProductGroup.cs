using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product group.
    /// </summary>
    public sealed class TargetGroupProductGroup : TargetGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="TargetGroupProductGroup"/> class.
        /// </summary>
        public TargetGroupProductGroup() : base()
        {
            ProductGroups = new HashSet<TargetProductGroup>();
        }

        /// <summary>
        /// Gets targeted product groups.
        /// </summary>
        public ISet<TargetProductGroup> ProductGroups { get; set; }
    }
}
