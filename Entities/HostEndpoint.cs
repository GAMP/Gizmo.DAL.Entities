using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Host endpoint entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostEndpoint : Host
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostEndpoint()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets maximum users.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int MaximumUsers
        {
            get;
            set;
        }

        #endregion
    }
}