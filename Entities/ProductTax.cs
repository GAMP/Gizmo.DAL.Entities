using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product tax entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTax : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTax() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int TaxId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if tax is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax.
        /// </summary>
        public virtual Tax Tax
        {
            get; set;
        }

        #endregion
    }
}