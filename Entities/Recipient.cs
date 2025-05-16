using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Recipient entity.
    /// </summary>
    public class Recipient : CreatedByOperatorBase , IDisable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Recipient()
        {
            Channels = new HashSet<RecipientChannel>();
        }

        /// <summary>
        /// Gets or sets if recipient is disabled.
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or sets the recipient channels.
        /// </summary>
        public ISet<RecipientChannel> Channels { get; set; }
    }
}
