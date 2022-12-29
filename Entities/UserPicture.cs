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
    /// User picture entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserPicture : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPicture()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets picture data.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public byte[] Picture
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user.
        /// </summary>
        public virtual User User
        {
            get;
            set;
        }

        #endregion
    }
}