using ProtoBuf;

using SharedLib;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User operator entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserOperator : User,
        IUserNameEmail
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserOperator()
            : base()
        {
            CreatedPayments = new HashSet<Payment>();
            ModifiedPayments = new HashSet<Payment>();
            CreatedDeposits = new HashSet<DepositTransaction>();
            ModifiedDeposits = new HashSet<DepositTransaction>();
            CreatedOrders = new HashSet<ProductOrder>();
            ModifiedOrders = new HashSet<ProductOrder>();
            Shifts = new HashSet<Shift>();
            RegisterTransactions = new HashSet<RegisterTransaction>();
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
        /// Gets or sets shift options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public ShiftOption ShiftOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets created payments.
        /// </summary>
        public virtual ISet<Payment> CreatedPayments { get; protected set; }

        /// <summary>
        /// Gets modified payments.
        /// </summary>
        public virtual ISet<Payment> ModifiedPayments { get; protected set; }

        /// <summary>
        /// Gets created deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> CreatedDeposits { get; protected set; }

        /// <summary>
        /// Gets modified deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> ModifiedDeposits { get; protected set; }

        /// <summary>
        /// Gets created orders.
        /// </summary>
        public virtual ISet<ProductOrder> CreatedOrders { get; protected set; }

        /// <summary>
        /// Gets modified orders.
        /// </summary>
        public virtual ISet<ProductOrder> ModifiedOrders { get; protected set; }

        /// <summary>
        /// Gets or sets opeator shifts.
        /// </summary>
        public virtual ISet<Shift> Shifts
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

        #endregion
    }
}