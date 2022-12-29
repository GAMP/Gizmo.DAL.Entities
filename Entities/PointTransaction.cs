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
    /// Points transaction entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PointTransaction : ModifiableByWithRequiredUserMemberBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new points transaction instance.
        /// </summary>
        public PointTransaction()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets balance transaction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public LoyalityPointsTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets points amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets points balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Balance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
}