#nullable enable

using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// File document entity.
    /// </summary>
    public sealed class FileDocument : File
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FileDocument()
        {
            Guid = Guid.NewGuid();
            InventoryDocuments = new HashSet<InventoryDocument>();
        }

        /// <summary>
        /// Gets or sets document type id.
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Document type.
        /// </summary>
        public DocumentType DocumentType { get; set; } = null!;

        /// <summary>
        /// Gets assigned inventories.
        /// </summary>
        public ISet<InventoryDocument> InventoryDocuments { get; set; } = null!; 
    }  
}
