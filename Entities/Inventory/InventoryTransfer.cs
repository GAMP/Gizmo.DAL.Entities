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
        /// Gets or sets the transfer stock.
        /// </summary>
        public Stock TransferStock { get; set; } = null!;
    }
}
