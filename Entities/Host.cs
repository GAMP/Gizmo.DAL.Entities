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
    /// Host entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Host : ModifiableByOperatorBase, IDeletable, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Host()
            : base()
        {
            UserSessions = new HashSet<UserSession>();
            UserSessionsChanges = new HashSet<UserSessionChange>();
            Layouts = new HashSet<HostLayoutGroupLayout>();
            ReservedGuests = new HashSet<UserGuest>();
            ProductOrders = new HashSet<ProductOrder>();
            Devices = new HashSet<DeviceHost>();
            Guid = Guid.NewGuid(); // always create a new GUID for the host
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets host name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// Gets or sets host state.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public HostState State { get; set; }

        /// <summary>
        /// Gets or sets icon id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? IconId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if host is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsDeleted
        {
            get; set;
        }

        /// <inheritdoc/>
        public Guid Guid
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets icon.
        /// </summary>
        public virtual Icon Icon { get; set; }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup { get; set; }

        /// <summary>
        /// Gets user sessions.
        /// </summary>
        public virtual ISet<UserSession> UserSessions { get; protected set; }

        /// <summary>
        /// Gets user sessions log.
        /// </summary>
        public virtual ISet<UserSessionChange> UserSessionsChanges { get; protected set; }

        /// <summary>
        /// Gets host layouts.
        /// </summary>
        public virtual ISet<HostLayoutGroupLayout> Layouts { get; protected set; }

        /// <summary>
        /// Gets reserved guest users.
        /// </summary>
        public virtual ISet<UserGuest> ReservedGuests
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets product orders.
        /// </summary>
        public virtual ISet<ProductOrder> ProductOrders
        {
            get; protected set;
        }

        /// <summary>
        /// Gets associated devices.
        /// </summary>
        [ProtoMember(100)]
        public virtual ISet<DeviceHost> Devices
        {
            get; protected set;
        }

        #endregion
    }
}