using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Extended invoice line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class InvoiceLineExtended : InvoiceLine
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineExtended() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle line id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? BundleLineId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets stock transaction id.
        /// <remarks>This value is set when order line generates stock transaction.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? StockTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock return transaction id.
        /// </summary>
        /// <remarks>
        /// This value is set when order line item is returned to stock.
        /// </remarks>
        [DataMember()]
        [ProtoMember(3)]
        public int? StockReturnTransactionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bundle line.
        /// </summary>
        public virtual InvoiceLineProduct BundleLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock transaction.
        /// </summary>
        public virtual StockTransaction StockTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets stock return transaction.
        /// </summary>
        public virtual StockTransaction StockReturnTransaction
        {
            get;
            set;
        }

        #endregion
    }
}