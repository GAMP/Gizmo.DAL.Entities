#nullable enable

using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Document entity.
    /// </summary>
    public sealed class Document : ModifiableByOperatorBase , IDeletable , IReplicatable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Document()
        {
            Guid = Guid.NewGuid();
            InventoryDocuments = new HashSet<InventoryDocument>();
        }

        /// <summary>
        /// Gets or sets document type id.
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        /// <remarks>
        /// This field will be used to store original file name.
        /// </remarks>
        public string FileName { get; set; } = null!;

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier.
        /// </summary>
        public Guid Guid { get; set; }

        ///<inheritdoc/>
        public bool IsDeleted { get; set; }

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
