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
    /// Invoice void entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class VoidInvoice : Void
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VoidInvoice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int InvoiceId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get; set;
        }

        #endregion
    }
}