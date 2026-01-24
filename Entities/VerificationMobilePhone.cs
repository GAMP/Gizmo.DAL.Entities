using System.ComponentModel.DataAnnotations;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Phone number verification entity.
    /// </summary>
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
        [MaxLength(20)]
        public string PhoneNumber
        {
            get; set;
        }

        #endregion
    }
}
