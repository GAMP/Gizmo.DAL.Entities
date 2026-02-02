#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User disable entry.
    /// </summary>
    public sealed class UserMemberDisableEntry : CreatedByOperatorBase
    {
        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; set; }

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
        public UserMemberDisableReason? DisableReason { get; set; }

        /// <summary>
        /// Entry user.
        /// </summary>
        public UserMember? User {  get; set; }
    }
}
