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
    /// Bill rate entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillRate : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRate() : base()
        {
            BillRateSteps = new HashSet<BillRateStep>();
            Days = new HashSet<BillRatePeriodDay>();
            Usage = new HashSet<UsageRate>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start fee.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal StartFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mimum fee.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal MinimumFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Rate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount of time charge will occur.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ChargeEvery
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount of time that after which charge will start. 
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int ChargeAfter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public BillRateOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if rate is default.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsDefault
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int BillProfileId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets billing profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets period days.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public virtual ISet<BillRatePeriodDay> Days
        {
            get; protected set;
        }

        /// <summary>
        /// Gets  steps.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public virtual ISet<BillRateStep> BillRateSteps
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets usages.
        /// </summary>
        public virtual ISet<UsageRate> Usage
        {
            get; protected set;
        }

        #endregion
    }
}