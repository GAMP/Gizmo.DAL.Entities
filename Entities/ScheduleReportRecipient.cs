namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule report recipient entity.
    /// </summary>
    public sealed class ScheduleReportRecipient : Recipient
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ScheduleReportRecipient() { }

        /// <summary>
        /// Schedule report id.
        /// </summary>
        public int ScheduleReportId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Schedule report.
        /// </summary>
        public ScheduleReport ScheduleReport { get; set; }

        /// <summary>
        /// Gets user.
        /// </summary>
        public UserOperator User { get; set; }
    }
}
