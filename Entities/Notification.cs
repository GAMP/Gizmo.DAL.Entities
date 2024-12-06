#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Notification entity.
    /// </summary>
    public class Notification : ModifiableByOperatorBase , IDisable
    {
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

        ///<inheritdoc/>
        public bool IsDisabled { get; set; }   
    }    
}
