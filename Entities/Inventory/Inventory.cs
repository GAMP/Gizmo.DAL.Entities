#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory base entity.
    /// </summary>
    public abstract class Inventory : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Inventory()
        {
            Entries = new HashSet<InventoryEntry>();
            Documents = new HashSet<InventoryDocument>();
        }

        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        public int? ShiftId { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        public Stock Stock { get; set; } = null!;

        /// <summary>
        /// Gets or sets the shift.
        /// </summary>
        public Shift Shift { get; set; } = null!;

        /// <summary>
        /// Gets or sets the inventory entries.
        /// </summary>
        public ISet<InventoryEntry> Entries { get; set; }

        /// <summary>
        /// Gets assigned documents.
        /// </summary>
        public ISet<InventoryDocument> Documents { get; private set; }
    }
}
