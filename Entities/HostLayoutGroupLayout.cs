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
    /// Host layout entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostLayoutGroupLayout : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroupLayout()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets x position.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int X
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets y postion.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Y
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if host layout is hidden.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsHidden
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets layout group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int HostLayoutGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int HostId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group.
        /// </summary>
        public virtual HostLayoutGroup HostLayoutGroup
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

        #endregion
    }
}