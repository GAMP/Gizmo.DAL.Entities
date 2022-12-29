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
    /// Host layout group image entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostLayoutGroupImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroupImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group.
        /// </summary>
        public virtual HostLayoutGroup HostLayoutGroup
        {
            get;
            set;
        }

        #endregion
    }
}