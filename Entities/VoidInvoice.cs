using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
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