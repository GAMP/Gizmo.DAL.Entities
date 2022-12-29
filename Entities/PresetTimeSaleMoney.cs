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
    /// Sale time money value entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PresetTimeSaleMoney : ValueBase<decimal>, IDisplayOrder
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PresetTimeSaleMoney() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int DisplayOrder
        {
            get; set;
        }

        #endregion
    }
}