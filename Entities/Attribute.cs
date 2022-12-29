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
    /// Attribute entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Attribute : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Attribute() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets attribute name.
        /// </summary>
        [Required()]
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets friendly name.
        /// </summary>
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(2)]
        public string FriendlyName
        {
            get; set;
        }

        #endregion
    }
}