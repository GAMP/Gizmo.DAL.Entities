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
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageRate() : base()
        {
        }

#nullable enable
        [NonSerialized()]
        private int? _discountId;
        [NonSerialized()]
        private DiscountCalculationType? _discountCalculationType;
        [NonSerialized()]
        private decimal? _discountValue;
        [NonSerialized()]
        private decimal _discountAmount;
        [NonSerialized()]
        private Discount? _discount;
#nullable disable

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

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        public int? DiscountId
        {
            get { return _discountId; }
            set { _discountId = value; }
        }

        /// <summary>
        /// Gets or sets discount calculation type.
        /// </summary>
        public DiscountCalculationType? DiscountCalculationType
        {
            get { return _discountCalculationType; }
            set { _discountCalculationType = value; }
        }

        /// <summary>
        /// Gets or sets discount value.
        /// </summary>
        public decimal? DiscountValue
        {
            get { return _discountValue; }
            set { _discountValue = value; }
        }

        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        public decimal DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        /// <summary>
        /// Gets or sets bill rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get; set;
        }

#nullable enable
        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public virtual Discount? Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
#nullable disable
    }
}
