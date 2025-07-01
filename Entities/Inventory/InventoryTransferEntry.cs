#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory transfer entry entity.
    /// </summary>
    public sealed class InventoryTransferEntry : InventoryEntry
    {
        /// <summary>
        /// Creates a new instance of the <see cref="InventoryTransferEntry"/> class.
        /// </summary>
        public InventoryTransferEntry()
        {
        }

        /// <summary>
        /// Gets or sets the transfer reason identifier.
        /// </summary>
        public int? TransferReasonId { get; set; }

        /// <summary>
        /// Gets or sets the transfer reason.
        /// </summary>
        public InventoryTransferReason? TransferReason { get; set; }
    }
}
