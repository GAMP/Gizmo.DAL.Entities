#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User disable reason.
    /// </summary>
    public sealed class UserMemberDisableReason : ModifiableByOperatorBase , IDisplayOrder
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserMemberDisableReason() : base()
        {
            Entries = new HashSet<UserMemberDisableEntry>();
        }

        /// <summary>
        /// Disable reason name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Disable reason description.
        /// </summary>
        public string? Description { get; set; }

        /// <inheritdoc/>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Disable entries.
        /// </summary>
        public ISet<UserMemberDisableEntry> Entries { get; set; }
    }
}
