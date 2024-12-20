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

        [NonSerialized()]
        private int? _reservationId;
        [NonSerialized()]
        private int? _reservationHostId;

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
        /// Gest or sets reservation id.
        /// </summary>
        public int? ReservationId
        {
            get { return _reservationId; }
            set { _reservationId = value; }
        }

        /// <summary>
        /// Gets or sets reservation host id.
        /// </summary>
        public int? ReservationHostId
        {
            get { return _reservationHostId; }
            set { _reservationHostId = value; }
        }

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductOLProduct BundleLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public Reservation Reservation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation host.
        /// </summary>
        public ReservationHost ReservationHost
        {
            get;
            set;
        }
    }
}
