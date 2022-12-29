using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Product time period day time.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class ProductTimePeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period day id.
        /// </summary>
        [DataMember()]
        public int PeriodDayId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets time period day.
        /// </summary>
        public virtual ProductTimePeriodDay Day
        {
            get; set;
        }

        #endregion
    }
}