#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory inbound entity.
    /// </summary>
    public sealed class InventoryInbound : Inventory
    {
        /// <summary>
        /// Gets or sets total cost.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets inventory transfer id.
        /// </summary>
        public int? InventoryTransferId { get; set; }

        /// <summary>
        /// Gets or sets transfer inventory.
        /// </summary>
        public InventoryTransfer? InventoryTransfer { get; set; }
    }
}
