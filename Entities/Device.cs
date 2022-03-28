using GizmoDALV2;
using GizmoDALV2.Entities;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Device entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Device : ModifiableByOperatorBase, IEnabled
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
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get; set;
        }

        /// <inheritdoc/>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsEnabled
        {
            get; set;
        }

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
