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
    /// Relation between executable and personal user file.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExePersonalFile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExePersonalFile()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets personal user file id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe { get; set; }

        /// <summary>
        /// Gets or sets personal user file.
        /// </summary>
        [ProtoMember(4, AsReference = true)]
        public virtual PersonalFile PersonalFile { get; set; }

        #endregion
    }
}