#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Notification timed.
    /// </summary>
    public abstract class NotificationTimed : Notification
    {
        /// <summary>
        /// Notification minute.
        /// </summary>
        public int Minute { get; set; }

        /// <summary>
        /// Gets or sets notification type.
        /// </summary>
        public NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets notification focus type.
        /// </summary>
        public NotificationFocusType FocusType { get; set; }

        /// <summary>
        /// Gets or sets notification message.
        /// </summary>
        public string? Message { get; set; }
    }
}
