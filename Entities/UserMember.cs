using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User member entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserMember : User,
        IUserNameEmail
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserMember()
            : base()
        {
            UserSessions = new HashSet<UserSession>();
            UserSessionsChanges = new HashSet<UserSessionChange>();

            AppRatings = new HashSet<AppRating>();
            AppStats = new HashSet<AppStat>();
            Payments = new HashSet<Payment>();
            Deposits = new HashSet<DepositTransaction>();
            LoayalityPoints = new HashSet<PointTransaction>();

            ProductOrders = new HashSet<ProductOrder>();
            ProductOrdersLines = new HashSet<ProductOL>();

            Invoices = new HashSet<Invoice>();
            InvoicePayments = new HashSet<InvoicePayment>();
            DepositPayments = new HashSet<DepositPayment>();
            InvoiceLines = new HashSet<InvoiceLine>();

            UsageSessions = new HashSet<UsageSession>();
            Usage = new HashSet<Usage>();
            Notes = new HashSet<UserNote>();

            AssetTransactions = new HashSet<AssetTransaction>();

            Reservations = new HashSet<Reservation>();

            PaymentIntents = new HashSet<PaymentIntent>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(30)]
        [ProtoMember(1)]
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember()]
        [StringLength(254)]
        [ProtoMember(2)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Gets or sets users group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UserGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user allowed to have negative balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool? IsNegativeBalanceAllowed
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if personal info is requested.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsPersonalInfoRequested
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public BillingOption? BillingOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user re-enable date-time.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public DateTime? EnableDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disabled date-time.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? DisabledDate
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user credit limit.
        /// </summary>
        public virtual UserCreditLimit UserCreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user sessions.
        /// </summary>
        public virtual ISet<UserSession> UserSessions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets session changes.
        /// </summary>
        public virtual ISet<UserSessionChange> UserSessionsChanges
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets app ratings.
        /// </summary>
        public virtual ISet<AppRating> AppRatings
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets app stats.
        /// </summary>
        public virtual ISet<AppStat> AppStats
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets payments.
        /// </summary>
        public virtual ISet<Payment> Payments
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> Deposits
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets loyality points.
        /// </summary>
        public virtual ISet<PointTransaction> LoayalityPoints
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user orders.
        /// </summary>
        public virtual ISet<ProductOL> ProductOrdersLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets product orders.
        /// </summary>
        public virtual ISet<ProductOrder> ProductOrders
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLine> InvoiceLines
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoices.
        /// </summary>
        public virtual ISet<Invoice> Invoices
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoice payments.
        /// </summary>
        public virtual ISet<InvoicePayment> InvoicePayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets deposit payments.
        /// </summary>
        public virtual ISet<DepositPayment> DepositPayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets bill sessions.
        /// </summary>
        public virtual ISet<UsageSession> UsageSessions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets usage.
        /// </summary>
        public virtual ISet<Usage> Usage
        {
            get; protected set;
        }

        /// <summary>
        /// Get or sets user notes.
        /// </summary>
        public virtual ISet<UserNote> Notes
        {
            get; set;
        }

        /// <summary>
        /// Gets asset transactions.
        /// </summary>
        public virtual ISet<AssetTransaction> AssetTransactions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets reservations.
        /// </summary>
        public virtual ISet<Reservation> Reservations
        {
            get; protected set;
        }

        /// <summary>
        /// Gets payment intents.
        /// </summary>
        public virtual ISet<PaymentIntent> PaymentIntents
        {
            get; protected set;
        }

        #endregion
    }
}