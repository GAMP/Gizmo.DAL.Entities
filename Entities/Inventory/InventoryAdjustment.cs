namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory adjustment entity.
    /// </summary>
    public sealed class InventoryAdjustment : Inventory
    {
        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        public int? InvoiceId { get; set; }

        /// <summary>
        /// Gets or sets adjustment type.
        /// </summary>
        public InventoryAdjustmentType AdjustmentType { get; set; }
    }
}
