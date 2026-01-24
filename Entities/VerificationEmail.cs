using System.ComponentModel.DataAnnotations;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Email verification entity.
    /// </summary>
    public class VerificationEmail : Verification
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VerificationEmail() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [MaxLength(254)]
        public string Email
        {
            get; set;
        }

        #endregion
    }
}
