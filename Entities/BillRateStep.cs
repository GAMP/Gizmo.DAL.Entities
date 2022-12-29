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
    /// Bill rate setp entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillRateStep : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRateStep() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets step minute.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Minute
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public BillRateStepAction Action
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets charge value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Charge
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets rate value.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Rate
        {
            get; set;
        }

        /// <summary>
        /// Get or sets target minute.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int TargetMinute
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing rate id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [Required()]
        public int BillRateId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets billing rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get;
            set;
        }

        #endregion
    }
}