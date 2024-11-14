using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Document type entity.
    /// </summary>
    public sealed class DocumentType : ModifiableByOperatorBase , IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        ///<inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets documents.
        /// </summary>
        public ISet<Document> Documents { get; set; }
    }
}
