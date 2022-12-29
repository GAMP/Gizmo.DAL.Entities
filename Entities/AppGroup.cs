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
    /// App group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppGroup : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppGroup()
            : base()
        {
            Guid = Guid.NewGuid();
            Apps = new HashSet<AppGroupApp>();
            HostGroups = new HashSet<HostGroup>();
            UserGroups = new HashSet<UserGroup>();
            TimeOffers = new HashSet<ProductTime>();
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
        /// Gets or sets item guid.
        /// </summary>
        [Required()]
        [ProtoMember(2)]
        [DataMember()]
        public Guid Guid
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets beloning applications.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<AppGroupApp> Apps
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets host groups that this profile belong to.
        /// </summary>
        [ProtoMember(4)]
        public virtual ISet<HostGroup> HostGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups that this profile belong to.
        /// </summary>
        [ProtoMember(5)]
        public virtual ISet<UserGroup> UserGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets time offers.
        /// </summary>
        [ProtoMember(6)]
        public virtual ISet<ProductTime> TimeOffers
        {
            get;
            protected set;
        }

        #endregion
    }
}