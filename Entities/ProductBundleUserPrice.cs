using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product Bundle user price.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductBundleUserPrice : UserGroupPriceBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBundleUserPrice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product bundle product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductBundleId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product bundle.
        /// </summary>
        public virtual ProductBundle ProductBundle
        {
            get; set;
        }

        #endregion
    }
}