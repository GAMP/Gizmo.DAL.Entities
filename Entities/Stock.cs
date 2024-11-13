#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities.Entities
{
    /// <summary>
    /// Stock entity.
    /// </summary>
    public sealed class Stock : ModifiableByOperatorBase, IBranchedOptionalEntity , IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Stock()
        {
            Counts = new HashSet<StockCount>();
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets stock type.
        /// </summary>
        public StockType Type { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <inheritdoc/>
        public int? BranchId { get; set; }

        /// <inheritdoc/>
        public Branch? Branch { get; set; }

        /// <summary>
        /// Gets associated stock counts.
        /// </summary>
        public ISet<StockCount> Counts { get; private set; }
    } 
}
