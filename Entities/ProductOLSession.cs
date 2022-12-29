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
    /// Usage session order line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOLSession : ProductOL
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLSession() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UsageSessionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets usage session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

        #endregion
    }
}