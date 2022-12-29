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
    /// Task Script entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskScript : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskScript()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets script type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public ScriptTypes ScriptType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        [StringLength(65535)]
        public string Data
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets process options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public TaskProcessOptionType ProcessOptions
        {
            get;
            set;
        }

        #endregion
    }
}