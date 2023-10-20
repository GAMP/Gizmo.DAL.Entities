using ProtoBuf;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product time period entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTimePeriod : PeriodDate
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriod() : base()
        {
            Days = new HashSet<ProductTimePeriodDay>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductTime ProductTime
        {
            get; set;
        }

        /// <summary>
        /// Gets days of week.
        /// </summary>
        [ProtoMember(1)]
        public ISet<ProductTimePeriodDay> Days
        {
            get; protected set;
        }

        #endregion
    }
}