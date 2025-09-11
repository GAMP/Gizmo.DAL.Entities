using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Reservation : ModifiableByUserCreatedByUserBase, IBranchedEntity
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Reservation()
        {
            Users = new HashSet<ReservationUser>();
            Hosts = new HashSet<ReservationHost>();
            InvoiceLines = new HashSet<InvoiceLine>();
            Orders = new HashSet<ReservationProductOrder>();
        }

        [NonSerialized()]
        private Branch _branch;
        [NonSerialized()]
        private User _finalizedBy;
        [NonSerialized()]
        private int? _finalizedById;
        [NonSerialized()]
        private int? _loginBlockBeforeTime;
        [NonSerialized()]
        private int? _loginBlockAfterTime;
        [NonSerialized()]
        private DateTime? _activationTime;
        [NonSerialized()]
        private ReservationPaymentStatus _paymentStatus;

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation pin.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [MinLength(6)]
        [MaxLength(6)]
        public string Pin
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation date time.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime Date
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets duration.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Range(1, int.MaxValue)]
        public int Duration
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact phone.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(20)]
        public string ContactPhone
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact email.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(254)]
        public string ContactEmail
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation note.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public string Note
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public SharedLib.ReservationStatus Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment status.
        /// </summary>
        public ReservationPaymentStatus PaymentStatus
        {
            get { return _paymentStatus; }
            set { _paymentStatus = value; }
        }

        /// <summary>
        /// Gets activation time.
        /// </summary>
        public DateTime? ActivationTime
        {
            get { return _activationTime; }
            set { _activationTime = value; }
        }

        /// <summary>
        /// Gets or sets expire after value.
        /// </summary>
        public int? ExpireAfter { get; set; }

        /// <summary>
        /// Gets or sets cancellation grace period.
        /// </summary>
        public int? CancellationGracePeriod { get; set; }

        /// <summary>
        /// Gets or sets cancellation refund percentage.
        /// </summary>
        public decimal CancellationRefundPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Minimum payment percentage.
        /// </summary>
        public decimal MinimumPaymentPercentage { get; set; }

        /// <summary>
        /// Gets or sets login block before time.
        /// </summary>
        public int? LoginBlockBeforeTime
        {
            get { return _loginBlockBeforeTime; }
            set { _loginBlockBeforeTime = value; }
        }

        /// <summary>
        /// Gets or sets login block after time.
        /// </summary>
        public int? LoginBlockAfterTime
        {
            get { return _loginBlockAfterTime; }
            set { _loginBlockAfterTime = value; }
        }

        /// <summary>
        /// Gets or sets finalized by user id.
        /// </summary>
        public int? FinalizedById
        {
            get { return _finalizedById; }
            set { _finalizedById = value; }
        }

        /// <inheritdoc/>        
        public int BranchId
        {
            get; set;
        }

        /// <summary>
        /// Gets finalized by user.
        /// </summary>
        public User FinalizedBy
        {
            get { return _finalizedBy; }
            set { _finalizedBy = value; }
        }

        /// <summary>
        /// Gets or sets reservation user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        /// <inheritdoc/>  
        public virtual Branch Branch
        {
            get { return _branch; }
            protected set { _branch = value; }
        }

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        [DataMember()]
        [ProtoMember(100)]
        public virtual ISet<ReservationUser> Users
        {
            get; protected set;
        }

        /// <summary>
        /// Gets entries.
        /// </summary>
        [DataMember()]
        [ProtoMember(101)]
        public virtual ISet<ReservationHost> Hosts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets related invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLine> InvoiceLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets related orders.
        /// </summary>
        public virtual ISet<ReservationProductOrder> Orders
        {
            get; set;
        }
    }
}
