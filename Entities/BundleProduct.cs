using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Bundle product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BundleProduct : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BundleProduct()
            : base()
        {
            UserPrices = new HashSet<BundleProductUserPrice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Price
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bundle id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int ProductBundleId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public ProductBundleOptionType Options
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user group prices.
        /// </summary>
        [ProtoMember(7)]
        public virtual ISet<BundleProductUserPrice> UserPrices
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductBundle ProductBundle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        #endregion
    }
}