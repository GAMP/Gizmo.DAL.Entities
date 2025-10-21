#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Order payment intent.
    /// </summary>
    public sealed class PaymentIntentOrder : PaymentIntent
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntentOrder() : base()
        {
            Orders = new HashSet<IntentOrder>();
            Deposits = new HashSet<IntentOrderDeposit>();
            Invoices = new HashSet<IntentInvoice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets auto complete.
        /// </summary>
        public bool AutoComplete { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets associated orders.
        /// </summary>
        public ISet<IntentOrder> Orders { get; }

        /// <summary>
        /// Gets associated deposits.
        /// </summary>
        public ISet<IntentOrderDeposit> Deposits { get; }

        /// <summary>
        /// Gets associated invoices.
        /// </summary>
        public ISet<IntentInvoice> Invoices { get; }

        #endregion
    }
}
