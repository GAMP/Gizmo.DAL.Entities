using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Notification focus type.
    /// </summary>
    [Flags()]
    public enum NotificationFocusType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0 ,
        /// <summary>
        /// Minimize windows.
        /// </summary>
        MinimizeWindows = 1,
    }
}
