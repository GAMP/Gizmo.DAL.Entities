using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule report.
    /// </summary>
    public sealed class ScheduleReport : Schedule
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ScheduleReport()
        {
            Entries = new HashSet<ScheduleReportEntry>();
            Recipients = new HashSet<RecipientScheduleReport>();
        }

        /// <summary>
        /// Gets or sets the schedule report entries.
        /// </summary>
        public ISet<ScheduleReportEntry> Entries { get; set; }

        /// <summary>
        /// Gets or sets the recipients.
        /// </summary>
        public ISet<RecipientScheduleReport> Recipients { get; set; }
    }
}
