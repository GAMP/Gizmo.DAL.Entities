using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entity that can have modfication time.
    /// </summary>
    public interface IModifiable : ICreatable
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets modification time.
        /// </summary>
        DateTime? ModifiedTime
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        bool IgnoreUpdatedUpdate { get; set; }

        #endregion
    }
}
