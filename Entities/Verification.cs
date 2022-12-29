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
    /// Verification entity base.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class Verification : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Verification() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets associated token id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int TokenId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets verification status.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public VerificationStatus Status
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPETIES

        /// <summary>
        /// Gets or sets associated token.
        /// </summary>
        public virtual Token Token
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        #endregion
    }
}