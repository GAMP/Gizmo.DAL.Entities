using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule entity.
    /// </summary>
    public abstract class Schedule : CreatedByOperatorBase, IDisable
    {
        /// <summary>
        /// Gets or sets schedule type.
        /// </summary>
        public ScheduleType Type { get; set; }

        /// <summary>
        /// Gets or sets schedule start time.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <inheritdoc/>
        public bool IsDisabled { get; set; }
    }
}
