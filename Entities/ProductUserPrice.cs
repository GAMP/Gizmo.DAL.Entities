using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Product user price entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductUserPrice : UserGroupPriceBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product user price instance.
        /// </summary>
        public ProductUserPrice()
            : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if product user price is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

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