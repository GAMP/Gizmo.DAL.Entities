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
    /// Bill rate period day entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BillRatePeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRatePeriodDay() : base()
        {
            Times = new HashSet<BillRatePeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bill rate period.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int BillRateId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets period day times.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public virtual ISet<BillRatePeriodDayTime> Times
        {
            get;
            protected set;
        }

        #endregion
    }
}