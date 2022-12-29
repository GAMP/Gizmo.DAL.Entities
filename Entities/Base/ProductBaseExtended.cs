using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Extended product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ProductBaseExtended : ProductBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBaseExtended()
            : base()
        {
            this.OrderLines = new HashSet<ProductOLProduct>();
            this.InvoiceLines = new HashSet<InvoiceLineProduct>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order lines.
        /// </summary>
        public virtual ISet<ProductOLProduct> OrderLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLineProduct> InvoiceLines
        {
            get;
            protected set;
        }

        #endregion
    }
}