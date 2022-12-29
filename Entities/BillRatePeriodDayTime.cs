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
    /// Bill rate period day time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BillRatePeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRatePeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time period day id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PeriodDayId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets period day.
        /// </summary>
        public virtual BillRatePeriodDay Day
        {
            get;
            set;
        }
        #endregion
    }
}