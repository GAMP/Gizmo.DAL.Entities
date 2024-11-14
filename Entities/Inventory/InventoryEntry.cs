#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory entry base entity.
    /// </summary>
    public abstract class InventoryEntry : CreatedByOperatorBase
    {
        /// <summary>
        /// Gets or sets the inventory id.
        /// </summary>
        public int InventoryId { get; set; }

        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the stock transaction id.
        /// </summary>
        public int StockTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        public int? ShiftId { get; set; }

        /// <summary>
        /// Gets or sets inventory.
        /// </summary>
        public Inventory Inventory { get; set; } = null!;

        /// <summary>
        /// Gets or sets stock transaction.
        /// </summary>
        public StockTransaction StockTransaction { get; set; } = null!;

        /// <summary>
        /// Gets or sets stock.
        /// </summary>
        public Stock Stock { get; set; } = null!;

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public ProductBase Product { get; set; } = null!;

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public Shift Shift { get; set; } = null!;
    }
}
