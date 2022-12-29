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
    /// User session change entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserSessionChange : CreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSessionChange()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserSessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int HostId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public SessionState State
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session span.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public double Span
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session slot.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int Slot
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user session.
        /// </summary>
        public virtual UserSession UserSession
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
}