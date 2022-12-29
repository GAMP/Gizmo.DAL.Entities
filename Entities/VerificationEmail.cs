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
    /// Email verification entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class VerificationEmail : Verification
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VerificationEmail() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [MaxLength(254)]
        public string Email
        {
            get; set;
        }

        #endregion
    }
}