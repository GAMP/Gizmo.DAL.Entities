using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Extended product order line entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ProductOLExtended : ProductOL
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLExtended() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle id.
        /// <remarks>This value is set when product is added as part of a bundle.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? BundleLineId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductOLProduct BundleLine
        {
            get;
            set;
        }

        #endregion
    }
}