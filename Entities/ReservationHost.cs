using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation host entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ReservationHost : ModifiableByUserCreatedByUserBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHost() : base()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        [NonSerialized()]
        private ReservationStatus _status;
        [NonSerialized()]
        private int? _finalizedById;
        [NonSerialized()]
        private User _finalizedBy;
        [NonSerialized()]
        private int? _movedToReservationHostId;

#nullable enable
        [NonSerialized()]
        private ReservationHost? _movedToReservationHost;
#nullable disable

        /// <summary>
        /// Gets or sets reservation id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ReservationId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets preferred user id.
        /// </summary>        
        [DataMember()]
        [ProtoMember(3)]
        public int? PreferredUserId
        {
            get; set;
        }

        /// <summary>
        /// Moved to reservation host id.
        /// </summary>
        public int? MovedToReservationHostId
        {
            get { return _movedToReservationHostId; }
            set { _movedToReservationHostId = value; }
        }

        /// <summary>
        /// Get or sets reservation status.
        /// </summary>
        public ReservationStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Gets host reservation activation time.
        /// </summary>
        public DateTime? ActivationTime {  get; set; }

        /// <summary>
        /// Gets or sets finalized by user id.
        /// </summary>
        public int? FinalizedById 
        {
            get { return _finalizedById; }
            set { _finalizedById = value; }
        }

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public virtual Reservation Reservation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets preferred user.
        /// </summary>
        public virtual UserMember PreferredUser
        {
            get; set;
        }

        /// <summary>
        /// Gets finalized by user.
        /// </summary>
        public User FinalizedBy
        {
            get { return _finalizedBy; }
            set { _finalizedBy = value; }
        }

        /// <summary>
        /// Gets related invoice lines.
        /// </summary>
        public ISet<InvoiceLine> InvoiceLines { get; set; }

#nullable enable
        /// <summary>
        /// Gets or sets moved to reservation host.
        /// </summary>
        public ReservationHost? MovedToReservationHost
        {
            get { return _movedToReservationHost; }
            set { _movedToReservationHost = value; }
        }
#nullable disable

    }
}
