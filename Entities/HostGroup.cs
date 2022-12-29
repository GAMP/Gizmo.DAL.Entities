using CoreLib;
using CyClone;
using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Host group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroup()
            : base()
        {
            Hosts = new HashSet<Host>();
            DisallowedTimeOffers = new HashSet<ProductTimeHostDisallowed>();
            DisallowedUserGroups = new HashSet<UserGroupHostDisallowed>();
            UserBillProfiles = new HashSet<HostGroupUserBillProfile>();
            WaitingLineEntries = new HashSet<HostGroupWaitingLineEntry>();
            HiddenProducts = new HashSet<ProductHostHidden>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
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
        /// Gets or sets skin name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string SkinName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if shell is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public HostGroupOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets app profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? AppGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? SecurityProfileId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets default guest group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? DefaultGuestGroupId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets waiting line.
        /// </summary>
        public virtual HostGroupWaitingLine WaitingLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets default guest group.
        /// </summary>
        public virtual UserGroup DefaultGuestGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app profile.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets hosts in this host group.
        /// </summary>
        public virtual ISet<Host> Hosts { get; protected set; }

        /// <summary>
        /// Gets or sets disallowed offers for this host group.
        /// </summary>
        public virtual ISet<ProductTimeHostDisallowed> DisallowedTimeOffers { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed user groups.
        /// </summary>
        public virtual ISet<UserGroupHostDisallowed> DisallowedUserGroups { get; protected set; }

        /// <summary>
        /// Gets user group bill profiles.
        /// </summary>
        [ProtoMember(100)]
        public virtual ISet<HostGroupUserBillProfile> UserBillProfiles { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed user groups.
        /// </summary>
        public virtual ISet<ProductHostHidden> HiddenProducts { get; protected set; }

        /// <summary>
        /// Gets waiting line entries for this host group.
        /// </summary>
        public virtual ISet<HostGroupWaitingLineEntry> WaitingLineEntries
        {
            get; protected set;
        }

        #endregion
    }
}