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
    /// Usage time fixed.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageTimeFixed : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageTimeFixed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time fixed order line id.
        /// </summary>
        public int InvoiceLineId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets product time fixed invoice line.
        /// </summary>
        public virtual InvoiceLineTimeFixed InvoiceLine
        {
            get; set;
        }
        #endregion
    }
}