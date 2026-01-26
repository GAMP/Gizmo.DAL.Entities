using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User session states.
    /// </summary>
    [Flags()]
    public enum SessionState
    {
        /// <summary>
        /// Session initialized.
        /// </summary>
        None = 0,

        /// <summary>
        /// Session is active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// Session ended.
        /// </summary>
        Ended = 2,

        /// <summary>
        /// Session pending termination.
        /// </summary>
        Pending = 4 | Active,

        /// <summary>
        /// Session paused and pending activation.
        /// </summary>
        Paused = 8 | Active,

        /// <summary>
        /// Session is moving.
        /// </summary>
        Move = 16 | Active,

        /// <summary>
        /// Grace period.
        /// </summary>
        Grace = 32 | Active
    }
}
