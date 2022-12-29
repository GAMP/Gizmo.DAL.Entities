using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Security profile entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfile()
            : base()
        {
            Restrictions = new HashSet<SecurityProfileRestriction>();
            Policies = new HashSet<SecurityProfilePolicy>();
            HostGroups = new HashSet<HostGroup>();
            UserGroups = new HashSet<UserGroup>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets disabled drives.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DisabledDrives
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets restrictions.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public virtual ISet<SecurityProfileRestriction> Restrictions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets policies.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public virtual ISet<SecurityProfilePolicy> Policies
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets host groups.
        /// </summary>
        public virtual ISet<HostGroup> HostGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups.
        /// </summary>
        public virtual ISet<UserGroup> UserGroups
        {
            get;
            protected set;
        }

        #endregion
    }
}