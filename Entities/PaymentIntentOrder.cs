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
            IntentOrders = new HashSet<IntentOrder>();
            IntentDeposits = new HashSet<IntentOrderDeposit>();
            IntentInvoices = new HashSet<IntentInvoice>();
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
        public ISet<IntentOrder> IntentOrders { get; }

        /// <summary>
        /// Gets associated deposits.
        /// </summary>
        public ISet<IntentOrderDeposit> IntentDeposits { get; }

        /// <summary>
        /// Gets associated invoices.
        /// </summary>
        public ISet<IntentInvoice> IntentInvoices { get; }

        #endregion
    }
}
