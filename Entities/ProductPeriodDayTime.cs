using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product perido day time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time offer period day id.
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
        /// Gets or sets time period day.
        /// </summary>
        public virtual ProductPeriodDay Day
        {
            get;
            set;
        }

        #endregion
    }
}