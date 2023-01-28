using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entity that can have deliverd status flags.
    /// </summary>
    public interface IDeliverable
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets if product is delivered.
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

        #endregion
    }
}
