using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entry that can be marked as delivered.
    /// </summary>
    public interface IDeliverable
    {
        /// <summary>
        /// Gets or sets if entry is delivered.
        /// </summary>
        bool IsDelivered
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets delivery time.
        /// </summary>
        DateTime? DeliveredTime
        {
            get;
            set;
        }
    }
}
