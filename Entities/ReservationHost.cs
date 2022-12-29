using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Reservation host entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ReservationHost : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHost() : base()
        {
        }
        #endregion

        #region PROPERTIES

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
        /// Gets or sets prefered user id.
        /// </summary>        
        [DataMember()]
        [ProtoMember(3)]
        public int? PreferedUserId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

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
        /// Gets or sets prefered user.
        /// </summary>
        public virtual UserMember PreferedUser
        {
            get; set;
        }

        #endregion
    }
}