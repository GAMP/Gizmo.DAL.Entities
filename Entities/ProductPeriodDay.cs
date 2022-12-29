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
    /// Product period day entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriodDay() : base()
        {
            Times = new HashSet<ProductPeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductPeriodId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public ProductPeriod Period
        {
            get;
            set;
        }

        /// <summary>
        /// Gets period day times.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<ProductPeriodDayTime> Times
        {
            get;
            set;
        }

        #endregion
    }
}