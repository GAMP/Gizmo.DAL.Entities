using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Waiting line timeout options.
    /// </summary>
    [Flags()]
    public enum WaitingLineTimeoutOption
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Remove.
        /// </summary>
        Remove = 1,
        /// <summary>
        /// Next in line.
        /// </summary>
        NextInLine = 2,
    }
}
