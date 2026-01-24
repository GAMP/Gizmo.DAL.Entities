using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Task notification options.
    /// </summary>
    [Flags()]
    public enum TaskNotificationOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Wait.
        /// </summary>
        Wait = 1,
    }
}
