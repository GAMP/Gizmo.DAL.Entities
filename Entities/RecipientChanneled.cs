using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Recipient channeled entity.
    /// </summary>
    public abstract class RecipientChanneled : Recipient
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RecipientChanneled()
        {
            Channels = new HashSet<RecipientChannel>();
        }

        /// <summary>
        /// Gets or sets the recipient channels.
        /// </summary>
        public ISet<RecipientChannel> Channels { get; set; }
    }
}
