namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count inventory adjustment entity.
    /// </summary>
    public sealed class StockCountAdjustment
    {
        /// <summary>
        /// Gets or sets stock count id.
        /// </summary>
        public int StockCountId { get; set; }

        /// <summary>
        /// Gets or sets inventory adjustment id.
        /// </summary>
        public int AdjustmentId { get; set; }

        /// <summary>
        /// Gets or sets stock count.
        /// </summary>
        public StockCount StockCount { get; set; } = null!;

        /// <summary>
        /// Gets or sets inventory adjustment.
        /// </summary>
        public InventoryAdjustment InventoryAdjustment { get; set; } = null!;
    }
}
