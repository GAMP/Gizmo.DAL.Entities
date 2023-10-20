using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User guest entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserGuest : UserMember
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGuest()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets account is joint.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public bool IsJoined
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if guest user is reserved.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsReserved
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reserved host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? ReservedHostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reserved slot.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? ReservedSlot
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets reserved host
        /// </summary>
        public virtual Host ReservedHost
        {
            get; set;
        }

        #endregion
    }
}