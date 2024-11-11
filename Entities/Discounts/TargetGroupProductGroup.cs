using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product group.
    /// </summary>
    public sealed class TargetGroupProductGroup : TargetGroup
    {
        /// <summary>
        /// Gets targeted product groups.
        /// </summary>
        public ISet<TargetProductGroup> ProductGroups { get; set; }
    }
}
