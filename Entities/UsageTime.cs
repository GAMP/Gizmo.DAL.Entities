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
    /// Usage time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageTime : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time order line id.
        /// </summary>
        [DataMember()]
        public int InvoiceLineId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets product time invoice line.
        /// </summary>
        public virtual InvoiceLineTime InvoiceLine
        {
            get; set;
        }
        #endregion
    }
}