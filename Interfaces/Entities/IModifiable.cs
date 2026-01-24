using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Represents an entity that can have modification time.
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
        /// Indicates that when entity is saved update time and user shouldn't be set automatically.
        /// </summary>
        bool IgnoreUpdatedUpdate { get; set; }

        #endregion
    }
}
