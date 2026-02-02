#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User disable entry.
    /// </summary>
    public sealed class UserDisableEntry : CreatedByOperatorBase
    {
        /// <summary>
        /// Entry type.
        /// </summary>
        public UserDisableEntryType Type { get; set; }

        /// <summary>
        /// Disable reason id.
        /// </summary>
        public int? DisableReasonId { get; set; }

        /// <summary>
        /// Disable note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Optional disable reason.
        /// </summary>
        public UserDisableReason? DisableReason { get; set; }
    }
}
