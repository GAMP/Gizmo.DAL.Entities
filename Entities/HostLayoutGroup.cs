using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Host layout group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostLayoutGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroup()
            : base()
        {
            Layouts = new HashSet<HostLayoutGroupLayout>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DisplayOrder
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group image.
        /// </summary>
        public virtual HostLayoutGroupImage Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets layouts.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<HostLayoutGroupLayout> Layouts
        {
            get;
            protected set;
        }

        #endregion
    }
}