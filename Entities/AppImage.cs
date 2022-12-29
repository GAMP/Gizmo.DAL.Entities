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
    /// App image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets app.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }
        #endregion
    }
}