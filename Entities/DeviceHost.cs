using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Host device relation entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class DeviceHost : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DeviceHost() : base()
        { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets device id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DeviceId
        {
            get; set;
        } 

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets device.
        /// </summary>
        public virtual Device Device
        {
            get; protected set;
        }

        /// <summary>
        /// Gets host.
        /// </summary>
        public virtual Host Host
        {
            get; protected set;
        } 

        #endregion
    }
}
