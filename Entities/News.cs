using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// News entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class News : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public News()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets feed data.
        /// <remarks>
        /// Data can be set to plain text or html.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Data
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets external url string.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(255)]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets media url string.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(255)]
        public string MediaUrl
        {
            get; set;
        }

        #endregion
    }
}