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
    /// Base restriction class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfileRestriction : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfileRestriction()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets restriction parameter.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string Parameter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets restriction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public RestrictionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int SecurityProfileId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        #endregion
    }
}