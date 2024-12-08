#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule entity.
    /// </summary>
    public abstract class Schedule : ModifiableByOperatorBase, IDisable
    {
        /// <summary>
        /// Schedule name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Schedule description.
        /// </summary>
        public string? Description { get; set; }

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
