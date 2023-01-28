using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Bundle product user price.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BundleProductUserPrice : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BundleProductUserPrice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product bundle id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int BundleProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal? Price
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Get or sets bundle product.
        /// </summary>
        public virtual BundleProduct BundleProduct
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
}