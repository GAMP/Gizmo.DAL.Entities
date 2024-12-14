#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// File entity.
    /// </summary>
    public class File : ModifiableByOperatorBase, IDeletable, IReplicatable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public File() 
        {
            Guid = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        /// <remarks>
        /// This field will be used to store original file name.
        /// </remarks>
        public string FileName { get; set; } = null!;

        /// <summary>
        /// Gets or sets file size.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets mime type.
        /// </summary>
        public string MimeType { get; set; } = null!;

        /// <summary>
        /// Gets or sets checksum hash.
        /// </summary>
        public byte[]? Hash { get; set; }

        ///<inheritdoc/>
        public Guid Guid { get; set; }

        ///<inheritdoc/>
        public bool IsDeleted { get; set; }
    }
}
