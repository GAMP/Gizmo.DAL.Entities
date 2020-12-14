using System;

namespace GizmoDALV2
{
    #region IReplicatable
    /// <summary>
    /// Represents an entity that support replication by exposing a unique GUID.
    /// </summary>
    public interface IReplicatable
    {
        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        Guid Guid
        {
            get;
            set;
        }
    }
    #endregion
}
