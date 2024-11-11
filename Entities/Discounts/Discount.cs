#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount base entity.
    /// </summary>
    public abstract class Discount : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Discount()
        {
            TargetGroups = new HashSet<TargetGroup>();
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets target groups.
        /// </summary>
        public virtual ISet<TargetGroup> TargetGroups { get; private set; }
    }
}
