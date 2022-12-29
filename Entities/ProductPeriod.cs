using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Product period entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriod : PeriodDate
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriod() : base()
        {
            Days = new HashSet<ProductPeriodDay>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        /// <summary>
        /// Gets days of week.
        /// </summary>
        [ProtoMember(1)]
        public virtual ISet<ProductPeriodDay> Days
        {
            get;
            protected set;
        }

        #endregion
    }
}