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
    }
}
