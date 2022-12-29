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
    /// Bill profile entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillProfile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillProfile() : base()
        {
            BillRates = new HashSet<BillRate>();
            UserGroups = new HashSet<UserGroup>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets rates.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<BillRate> BillRates
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups.
        /// </summary>
        public virtual ISet<UserGroup> UserGroups
        {
            get; protected set;
        }

        #endregion
    }
}