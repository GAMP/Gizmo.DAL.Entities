using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Product bundle entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductBundle : ProductBaseExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBundle()
            : base()
        {
            BundledProducts = new HashSet<BundleProduct>();
            UserPrices = new HashSet<ProductBundleUserPrice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle stock options.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public BundleStockOptionType BundleStockOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets bundled products.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<BundleProduct> BundledProducts
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets user group prices.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<ProductBundleUserPrice> UserPrices
        {
            get; protected set;
        }

        #endregion
    }
}