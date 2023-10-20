using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Price base class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class PriceBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of price base.
        /// </summary>
        public PriceBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets fixed price.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal? Price
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets price in points.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? PointsPrice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets purchase options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        #endregion
    }
}