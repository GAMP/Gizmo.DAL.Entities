using CoreLib;
using CyClone;
using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Reservation user entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ReservationUser : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationUser()
        { }
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
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
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
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
}