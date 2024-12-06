using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Recipient channel entity.
    /// </summary>
    public sealed class RecipientChannel : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RecipientChannel()
        {
        }

        /// <summary>
        /// Gets or sets channel type.
        /// </summary>
        public Guid ChannelType { get; set; }

        /// <summary>
        /// Gets or sets recipient channeled id.
        /// </summary>
        public int RecipientChanneledId { get; set; }

        /// <summary>
        /// Gets or sets recipient channeled.
        /// </summary>
        public RecipientChanneled RecipientChanneled { get; set; }
    }
}
