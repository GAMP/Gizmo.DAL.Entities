using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Rate usage entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageRate : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageRate() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bill profile rate id.
        /// </summary>
        [DataMember()]
        public int BillRateId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [DataMember()]
        public decimal Total
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets rate.
        /// </summary>
        [DataMember()]
        public decimal Rate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile time stamp.
        /// </summary>
        [DataMember()]
        public DateTime BillProfileStamp
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get; set;
        }

        #endregion
    }
}