using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product image instance.
        /// </summary>
        public ProductImage() : base()
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
            get;
            set;
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