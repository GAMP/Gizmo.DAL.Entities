#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory inbound entry entity.
    /// </summary>
    public sealed class InventoryInboundEntry : InventoryEntry
    {
        /// <summary>
        /// Gets or sets unit cost.
        /// </summary>
        public decimal UnitCost { get; set; }

        /// <summary>
        /// Gets or sets total cost.
        /// </summary>
        public decimal TotalCost { get; set; }

        /// <summary>
        /// Gets or sets expiration date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets inventory transfer entry id.
        /// </summary>
        public int? InventoryTransferEntryId { get; set; }

        /// <summary>
        /// Gets or sets inventory transfer entry.
        /// </summary>
        public InventoryTransferEntry? InventoryTransferEntry { get; set; }
    }
}
