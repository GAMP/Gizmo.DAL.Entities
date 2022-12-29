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
    /// User note entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserNote : Note
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserNote() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user note options.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public UserNoteOptions UserNoteOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

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