using ProtoBuf;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Invoice : ModifiableByWithRequiredUserMemberBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Invoice() : base()
        {
            InvoicePayments = new HashSet<InvoicePayment>();
            InvoiceLines = new HashSet<InvoiceLine>();
            Voids = new HashSet<VoidInvoice>();
            FiscalReceipts = new HashSet<InvoiceFiscalReceipt>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product order id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductOrderId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public InvoiceStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice sub total amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal SubTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of points.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets invoice total amount of tax.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal TaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount.
        /// </summary>
        /// <remarks>
        /// This amount is sum of sub total and tax total.
        /// </remarks>
        [DataMember()]
        [ProtoMember(6)]
        public decimal Total
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets outstanding amount.
        /// </summary>
        [DataMember]
        [ProtoMember(7)]
        public decimal Outstanding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets outstanding points.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int OutstandngPoints
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
        /// Gets or sets if invoice is voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public bool IsVoided
        {
            get; set;
        }

        /// <summary>
        /// Gets sale fiscal receipt status.
        /// </summary>
        [DataMember()]
        [ProtoMember(18)]
        public int SaleFiscalReceiptStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets return fiscal receipt status.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public int ReturnFiscalReceiptStatus
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets payments maid against this invoice.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public virtual ISet<InvoicePayment> InvoicePayments
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets invoice lines.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public virtual ISet<InvoiceLine> InvoiceLines
        {
            get; protected set;
        }

        /// <summary>
        /// Gets voids.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public virtual ISet<VoidInvoice> Voids
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets product order.
        /// </summary>
        [DataMember()]
        [ProtoMember(15, AsReference = true)]
        public virtual ProductOrder ProductOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
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
        /// Gets or sets fiscal receipts.
        /// </summary>
        [ProtoMember(17)]
        public ISet<InvoiceFiscalReceipt> FiscalReceipts
        {
            get; set;
        }

        #endregion
    }
}