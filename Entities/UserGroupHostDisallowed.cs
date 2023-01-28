using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User group host disallowed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserGroupHostDisallowed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroupHostDisallowed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disallowed value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDisallowed
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        #endregion
    }
}