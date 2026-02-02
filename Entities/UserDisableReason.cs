#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User disable reason.
    /// </summary>
    public sealed class UserDisableReason : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserDisableReason() : base()
        {
            Entries = new HashSet<UserDisableEntry>();
        }

        /// <summary>
        /// Disable reason name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Disable reason description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Disable entries.
        /// </summary>
        public ISet<UserDisableEntry> Entries { get; set; }
    }
}
