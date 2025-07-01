#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory transfer reason entity.
    /// </summary>
    public sealed class InventoryTransferReason : ModifiableByOperatorBase , IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InventoryTransferReason()
        {
            TransferEntries = new HashSet<InventoryTransferEntry>();
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
        public ISet<InventoryTransferEntry> TransferEntries { get; set; }
    }
}
