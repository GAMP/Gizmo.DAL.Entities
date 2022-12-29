using CoreLib;
using CyClone;
using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Invoice payment refund.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class RefundInvoicePayment : Refund
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RefundInvoicePayment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int InvoicePaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int InvoiceId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets invoice payment.
        /// </summary>
        public virtual InvoicePayment InvoicePayment
        {
            get; set;
        }

        /// <summary>
        /// Gets or set invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get; set;
        }

        #endregion
    }
}