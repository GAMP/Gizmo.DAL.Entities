namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory adjustment entry entity.
    /// </summary>
    public sealed class InventoryAdjustmentEntry : InventoryEntry
    {
        /// <summary>
        /// Gets or sets the unit cost.
        /// </summary>
        public decimal UnitCost { get; set; }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the total cost.
        /// </summary>
        public decimal TotalCost { get; set; }

        /// <summary>
        /// Gets or sets the total price.
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets the adjustment reason id.
        /// </summary>
        public int? AdjustmentReasonId { get; set; }

        /// <summary>
        /// Adjustment reason.
        /// </summary>
        public InventoryAdjustmentReason AdjustmentReason { get; set; } = null!;
    }
}
