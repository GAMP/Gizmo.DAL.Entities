#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount base entity.
    /// </summary>
    public abstract class Discount : ModifiableByOperatorBase , IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Discount()
        {
            Branches = new HashSet<DiscountBranch>();
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets discount branches.
        /// </summary>
        public ISet<DiscountBranch> Branches { get; private set; }  
    }
}
