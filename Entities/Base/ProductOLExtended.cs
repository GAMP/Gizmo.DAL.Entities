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
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLExtended() : base()
        { }

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

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductOLProduct BundleLine
        {
            get;
            set;
        }
    }
}
