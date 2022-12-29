using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// User credential entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public partial class UserCredential : ModifiableByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserCredential()
            : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        public byte[] Password { get; set; }

        /// <summary>
        /// Gets or sets salt.
        /// </summary>
        public byte[] Salt { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}