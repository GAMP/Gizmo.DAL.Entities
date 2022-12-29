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
    /// App stat entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppStat : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppStat()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets total span.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public double Span { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int HostId { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int UserId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual HostComputer Host
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