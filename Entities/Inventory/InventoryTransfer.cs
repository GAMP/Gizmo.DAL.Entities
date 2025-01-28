#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory transfer entity.
    /// </summary>
    public sealed class InventoryTransfer : Inventory
    {
        /// <summary>
        /// Gets or sets the transfer stock id.
        /// </summary>
        public int TransferStockId { get; set; }

        /// <summary>
        /// Gets or sets inbound inventory id.
        /// </summary>
        public int? InventoryInboundId { get; set; }

        /// <summary>
        /// Gets or sets the transfer stock.
        /// </summary>
        public Stock TransferStock { get; set; } = null!;

        /// <summary>
        /// Gets or sets inbound inventory.
        /// </summary>
        public InventoryInbound? InventoryInbound { get; set; }
    }
}
