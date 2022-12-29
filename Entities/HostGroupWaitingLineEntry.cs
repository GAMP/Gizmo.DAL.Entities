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
    /// Waiting line entry.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroupWaitingLineEntry : ModifiedByBase<UserOperator, User>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroupWaitingLineEntry() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets waiting line id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line number.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Position
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if position was set manually.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsManualPosition
        {
            get; set;
        }

        /// <summary>
        /// Gets total time in waiting line.
        /// </summary>
        [ProtoMember(5)]
        public double TimeInLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ready time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public double ReadyTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if ready state timed out.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsReadyTimedOut
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line state.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public WaitingLineState State
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line.
        /// </summary>
        public virtual HostGroupWaitingLine WatingLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
}