using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Host state.
    /// </summary>
    [Flags()]
    public enum HostState
    {
        /// <summary>
        /// Default state.
        /// </summary>
        InOrder = 0,

        /// <summary>
        /// Host is out of order.
        /// </summary>
        OutOfOrder = 1,

        /// <summary>
        /// Host is locked.
        /// </summary>
        IsLocked = 2,
    }
}
