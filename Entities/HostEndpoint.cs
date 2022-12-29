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
    /// Host endpoint entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostEndpoint : Host
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostEndpoint()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets maximum users.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int MaximumUsers
        {
            get;
            set;
        }

        #endregion
    }
}