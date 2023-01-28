using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Host group user bill profile entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroupUserBillProfile : EntityBase,
        IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroupUserBillProfile() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int BillProfileId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
}