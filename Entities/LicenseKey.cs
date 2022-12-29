using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Application license key entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class LicenseKey : ModifiableByOperatorBase, IReplicatable, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LicenseKey()
            : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int LicenseId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. 
        /// In case of exporting or importing applications it gives us ability to have unique objects.
        /// </remarks>
        /// </summary>
        [Required()]
        [DataMember()]
        [ProtoMember(2)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(3)]
        public string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if license key is enabled.
        /// <remarks>
        /// When disabled license key is not used within license reservation.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [IgnoreDataMember()]
        [Required()]
        [ProtoMember(5)]
        public byte[] Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets optional assigned host computer id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? AssignedHostId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets license.
        /// </summary>
        public virtual License License
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets assigned computer host.
        /// </summary>
        public virtual HostComputer AssignedHost
        {
            get; set;
        }

        #endregion
    }
}