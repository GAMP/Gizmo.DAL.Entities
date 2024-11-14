#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory adjustment reason entity.
    /// </summary>
    public sealed class InventoryAdjustmentReason : ModifiableByOperatorBase , IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InventoryAdjustmentReason()
        {
            AdjustmentEntries = new HashSet<InventoryAdjustmentEntry>();
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
        /// Gets or sets the adjustment entries.
        /// </summary>
        public ISet<InventoryAdjustmentEntry> AdjustmentEntries { get; set; }
    }
}
