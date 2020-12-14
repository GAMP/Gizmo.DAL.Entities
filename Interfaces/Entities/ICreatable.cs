using System;

namespace GizmoDALV2
{
    #region ICreatable
    /// <summary>
    /// Represents an entity that can have creation time.
    /// </summary>
    public interface ICreatable
    {
        /// <summary>
        /// Gets or sets creation time.
        /// </summary>
        DateTime CreatedTime
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved creation time and user shouldnt be set automatically.
        /// </summary>
        bool IgnoreCreatedUpdate { get; set; }
    }
    #endregion
}
