using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ProtoBuf;
using SharedLib;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product order entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOrder : ModifiableByWithRequiredUserMemberBase, IDeletable, IVoidable, IDeliverable, IPreparable, IBranchedOptionalEntity
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOrder()
        {
            OrderLines = new HashSet<ProductOL>();
            Invoices = new HashSet<Invoice>();
            PaymentIntents = new HashSet<PaymentIntentOrder>();
            Discounts = new HashSet<ProductOrderDiscount>();
        }

        [NonSerialized()]
        private OrderPrepareStatus _prepareStatus;
        [NonSerialized()]
        private DateTime? _prepareTime;
        [NonSerialized()]
        private decimal _preparedQuantity;
        [NonSerialized]
        private int? _branchId;
        [NonSerialized]
        private Branch _branch;

        /// <summary>
        /// Gets or sets order status.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public SharedLib.OrderStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets sub total.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal SubTotal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets sub total.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Total
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets total points.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal Tax
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if entity is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets preferred payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public int? PreferredPaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if delivered.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets delivered time.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public DateTime? DeliveredTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order source.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public OrderSource Source
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order source.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        [MaxLength(255)]
        public string UserNote
        {
            get; set;
        }

        /// <inheritdoc/>
        public OrderPrepareStatus PrepareStatus
        {
            get { return _prepareStatus; }
            set { _prepareStatus = value; }
        }

        /// <inheritdoc/>
        public decimal PreparedQuantity
        {
            get { return _preparedQuantity; }
            set { _preparedQuantity = value; }
        }

        /// <inheritdoc/>
        public DateTime? PrepareTime
        {
            get { return _prepareTime; }
            set { _prepareTime = value; }
        }

        /// <summary>
        /// Gets or sets branch id.
        /// </summary>
        public int? BranchId
        {
            get { return _branchId; }
            set { _branchId = value; }
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets order products.
        /// </summary>
        [ProtoMember(9)]
        public virtual ISet<ProductOL> OrderLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets invoices.
        /// </summary>
        [ProtoMember(10)]
        public virtual ISet<Invoice> Invoices
        {
            get;
            protected set;
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

        /// <summary>
        /// Gets or sets preferred payment method.
        /// </summary>
        public virtual PaymentMethod PreferredPaymentMethod
        {
            get; set;
        }

        /// <summary>
        /// Gets payment intents.
        /// </summary>
        public virtual ISet<PaymentIntentOrder> PaymentIntents
        {
            get; protected set;
        }

        /// <summary>
        /// Gets order discounts.
        /// </summary>
        public virtual ISet<ProductOrderDiscount> Discounts { get; protected set; }



        /// <summary>
        /// Gets or sets branch.
        /// </summary>
        public Branch Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }
    }
}
