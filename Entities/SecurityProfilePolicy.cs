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
    /// Security profile policy entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfilePolicy : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfilePolicy()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets policy type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public SecurityPolicyType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
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