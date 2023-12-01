using ProtoBuf;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Reservation : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Reservation()
        {
            Users = new HashSet<ReservationUser>();
            Hosts = new HashSet<ReservationHost>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation pin.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [MinLength(6)]
        [MaxLength(6)]
        public string Pin
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation date time.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime Date
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets duration.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Range(1, int.MaxValue)]
        public int Duration
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact phone.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(20)]
        public string ContactPhone
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact email.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(254)]
        public string ContactEmail
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation note.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public string Note
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public SharedLib.ReservationStatus Status
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        [DataMember()]
        [ProtoMember(100)]
        public virtual ISet<ReservationUser> Users
        {
            get; protected set;
        }

        /// <summary>
        /// Gets entries.
        /// </summary>
        [DataMember()]
        [ProtoMember(101)]
        public virtual ISet<ReservationHost> Hosts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets reservation user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
}