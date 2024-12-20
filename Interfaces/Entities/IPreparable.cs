using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entry that can be marked as prepared.
    /// </summary>
    public interface IPreparable
    {
        /// <summary>
        /// Gets or sets if entry is prepared.
        /// </summary>
        public bool? IsPrepared { get; set; }

        /// <summary>
        /// Gets or sets entry preparation time.
        /// </summary>
        public DateTime? PrepareTime { get; set; }
    }
}
