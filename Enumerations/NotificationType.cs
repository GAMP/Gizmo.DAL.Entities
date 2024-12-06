using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Notification type.
    /// </summary>
    [Flags()]
    public enum NotificationType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Visual.
        /// </summary>
        Visual = 1,
        /// <summary>
        /// Audible.
        /// </summary>
        Audible = 2,
    }
}
