using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Coupon class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Coupon : ModifiableByOperatorBase, IDisable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Coupon() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets voucher name.
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
        /// Gets or sets voucher tag.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string Tag
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets maximum usage.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? MaximumUsage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voucher is disabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDisabled
        {
            get; set;
        }

        #endregion
    }
}