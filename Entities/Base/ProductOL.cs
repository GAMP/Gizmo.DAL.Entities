using ProtoBuf;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product order line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOL : ModifiableByWithRequiredUserMemberBase, IDeletable, IVoidable, IDeliverable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOL() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets order id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductOrderId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string ProductName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order line quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal UnitPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal UnitListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points unit price.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int UnitPointsPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal? UnitCost
        {
            get; set;
        }

        /// <summary>
        /// Gets or set total price.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public decimal Total
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total points price.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product points.
        /// </summary>
        /// <remarks>
        /// This value specified amount of points user gets per unit.
        /// </remarks>
        [DataMember()]
        [ProtoMember(10)]
        public int? Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points award for the order line.
        /// </summary>
        /// <remarks>This value specifies total award user will recieve for this item.
        /// The value can be zero in case such as when user pays with points.
        /// </remarks>
        [DataMember()]
        [ProtoMember(11)]
        public int PointsAward
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax rate.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public decimal TaxRate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of tax.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal TaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total taxed price.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public decimal PreTaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(18)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pay type.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public SharedLib.OrderLinePayType PayType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unit list price.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public int? UnitPointsListPrice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets cost.
        /// </summary>
        [DataMember()]
        [ProtoMember(21)]
        public decimal? Cost
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if delivered.
        /// </summary>
        [DataMember()]
        [ProtoMember(22)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets delivered quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(23)]
        public decimal DeliveredQuantity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets delivered time.
        /// </summary>
        [DataMember()]
        [ProtoMember(24)]
        public DateTime? DeliveredTime
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        public virtual ProductOrder ProductOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
}