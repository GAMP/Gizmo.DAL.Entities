namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule report recipient entity.
    /// </summary>
    public sealed class RecipientScheduleReport : CreatedByOperatorBase , IDisable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RecipientScheduleReport() { }

        /// <summary>
        /// Schedule report id.
        /// </summary>
        public int ScheduleReportId { get; set; }

        /// <summary>
        /// Recipient id.
        /// </summary>
        public int RecipientId { get; set; }

        ///<inheritdoc/>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Schedule report.
        /// </summary>
        public ScheduleReport ScheduleReport { get; set; }

        /// <summary>
        /// Recipient.
        /// </summary>
        public Recipient Recipient { get; set; }
    }
}
