namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory inbound entity.
    /// </summary>
    public sealed class InventoryInbound : Inventory
    {
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public decimal Cost { get; set; }
    }
}
