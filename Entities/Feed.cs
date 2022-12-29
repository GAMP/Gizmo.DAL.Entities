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
    /// Feed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class Feed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Feed()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets maximum results.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Maximum
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets feed url.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Required()]
        [StringLength(255)]
        public string Url
        {
            get;
            set;
        }

        #endregion
    }
}