using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Phone number verification entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class VerificationMobilePhone : Verification
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VerificationMobilePhone() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [MaxLength(20)]
        public string PhoneNumber
        {
            get; set;
        }

        #endregion
    }
}