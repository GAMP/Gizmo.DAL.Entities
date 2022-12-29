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
    /// Product time period day.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTimePeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriodDay() : base()
        {
            Times = new HashSet<ProductTimePeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductTimePeriodId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public virtual ProductTimePeriod Period
        {
            get; set;
        }

        /// <summary>
        /// Gets or set day times.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<ProductTimePeriodDayTime> Times
        {
            get; protected set;
        }

        #endregion
    }
}