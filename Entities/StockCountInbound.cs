namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count inventory inbound entity.
    /// </summary>
    public sealed class StockCountInbound
    {
        /// <summary>
        /// Gets or sets stock count id.
        /// </summary>
        public int StockCountId { get; set; }

        /// <summary>
        /// Gets or sets inventory adjustment id.
        /// </summary>
        public int InboundId { get; set; }

        /// <summary>
        /// Gets or sets stock count.
        /// </summary>
        public StockCount StockCount { get; set; } = null!;

        /// <summary>
        /// Gets or sets inventory inbound.
        /// </summary>
        public InventoryInbound InventoryInbound { get; set; } = null!;
    }
}
