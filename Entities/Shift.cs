using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Shift entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Shift : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Shift() : base()
        {
            ShiftCounts = new HashSet<ShiftCount>();
            RegisterTransactions = new HashSet<RegisterTransaction>();
            Deposits = new HashSet<DepositTransaction>();
            DepositPayments = new HashSet<DepositPayment>();
            InvoicePayment = new HashSet<InvoicePayment>();
            Payments = new HashSet<Payment>();
            Refunds = new HashSet<Refund>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets if shift is currently active.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets operator id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int OperatorId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime Start
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal StartCash
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if shift is ending.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsEnding
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ended user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? EndedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? EndTime
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        public virtual UserOperator Operator
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ended operator.
        /// </summary>
        public virtual UserOperator EndedBy
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
        /// Gets or sets shift counts.
        /// </summary>
        public virtual ISet<ShiftCount> ShiftCounts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets register transactions.
        /// </summary>
        public virtual ISet<RegisterTransaction> RegisterTransactions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> Deposits
        {
            get; set;
        }

        /// <summary>
        /// Gets deposit payments.
        /// </summary>
        public virtual ISet<DepositPayment> DepositPayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets invoice payments.
        /// </summary>
        public virtual ISet<InvoicePayment> InvoicePayment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payments.
        /// </summary>
        public virtual ISet<Payment> Payments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets refunds.
        /// </summary>
        public virtual ISet<Refund> Refunds
        {
            get; protected set;
        }

        #endregion
    }
}