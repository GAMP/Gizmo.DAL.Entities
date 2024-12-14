namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory document entity.
    /// </summary>
    public sealed class InventoryDocument : CreatedByOperatorBase
    {
        /// <summary>
        /// Gets or sets the inventory id.
        /// </summary>
        public int InventoryId { get; set; }

        /// <summary>
        /// Gets or sets the document id.
        /// </summary>
        public int FileDocumentId { get; set; }

        /// <summary>
        /// Gets or sets the inventory.
        /// </summary>
        public Inventory Inventory { get; set; }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        public FileDocument Document { get; set; }
    }
}
