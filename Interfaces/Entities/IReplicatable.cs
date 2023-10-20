using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entity that support replication by exposing a unique GUID.
    /// </summary>
    public interface IReplicatable
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        Guid Guid
        {
            get;
            set;
        }

        #endregion
    }
}
