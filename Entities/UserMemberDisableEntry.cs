#nullable enable

using System;
using Gizmo.DAL.Entities.Enumerations;

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
        public required int UserId { get; set; }

        /// <summary>
        /// Entry type.
        /// </summary>
        public UserMemberDisableEntryType Type { get; set; }

        /// <summary>
        /// Disable reason id.
        /// </summary>
        public int? DisableReasonId { get; set; }

        /// <summary>
        /// Disable note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Re-enable date.
        /// </summary>
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// Acknowledge state.
        /// </summary>
        public UserMemberDisableAcknowledgeState AcknowledgeState { get; set; }

        /// <summary>
        /// Acknowledge date/time.
        /// </summary>
        public DateTime? AcknowledgedDate { get; set; }

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
