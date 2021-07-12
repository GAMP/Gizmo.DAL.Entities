using GizmoDALV2;
using GizmoDALV2.Entities;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Device entity.
    /// </summary>
    public class Device : ModifiableByOperatorBase, IEnabled, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Device() : base()
        {
            Hosts = new HashSet<DeviceHost>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set device name.
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <inheritdoc/>
        public bool IsEnabled
        {
            get; set;
        }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets associated hosts.
        /// </summary>
        public virtual ISet<DeviceHost> Hosts
        {
            get; protected set;
        }
        
        #endregion
    }
}
