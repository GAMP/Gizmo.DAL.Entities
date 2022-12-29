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
    /// Task process entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskProcess : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskProcess()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets process file name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets arguments.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// Gets or sets working directory.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [StringLength(45)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(45)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public TaskProcessOptionType ProcessOptions
        {
            get;
            set;
        }

        #endregion
    }
}