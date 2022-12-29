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
    /// Invoice line product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineProduct : InvoiceLineExtended, IOrderLineReference
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineProduct() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order line.
        /// </summary>
        public virtual ProductOLProduct OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBaseExtended Product
        {
            get; set;
        }

        #endregion
    }
}