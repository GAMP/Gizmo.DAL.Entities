#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule report entry.
    /// </summary>
    public sealed class ScheduleReportEntry : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ScheduleReportEntry() { }

        /// <summary>
        /// Gets or sets the schedule report id.
        /// </summary>
        public int ScheduleReportId { get; set; }

        /// <summary>
        /// Gets or sets the schedule report type.
        /// </summary>
        public Guid ReportType { get; set; }

        /// <summary>
        /// Gets or sets the report range.
        /// </summary>
        public ReportPresetRange ReportRange { get; set; }

        /// <summary>
        /// Gets or sets the report parameters.
        /// </summary>
        public string? ReportParameters { get; set; } = null;

        /// <summary>
        /// Gets or sets the report preset id.
        /// </summary>
        public int? ReportPresetId { get; set; }

        /// <summary>
        /// Gets or sets the schedule report.
        /// </summary>
        public ScheduleReport ScheduleReport { get; set; } = null!;

        /// <summary>
        /// Gets or sets the report preset.
        /// </summary>
        public ReportPreset? ReportPreset { get; set; }
    }
}
