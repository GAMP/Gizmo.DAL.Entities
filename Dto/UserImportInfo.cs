using SharedLib;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.DTO
{
    /// <summary>
    /// Generic user import information class.
    /// </summary>
    /// <remarks>
    /// Purpose of a class to describe imported user.
    /// </remarks>
    [DataContract()]
    public class UserImportInfo
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        public string Username
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [DataMember()]
        public string FirstName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [DataMember()]
        public string LastName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets registration date.
        /// </summary>
        [DataMember(IsRequired = false)]
        public DateTime? RegistrationDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets birth date.
        /// </summary>
        [DataMember(IsRequired = false)]
        public DateTime? BirthDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets desired user group name.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string UserGroupName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string Country
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string City
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string Address
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets postcode.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string PostCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user email.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string Email
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string Phone
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets mobile phone number.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string MobilePhone
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets sex.
        /// </summary>
        [DataMember()]
        public Sex Sex
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if user is banned.
        /// </summary>
        [DataMember()]
        public bool IsBanned
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of user deposits.
        /// </summary>
        [DataMember()]
        public decimal Deposits
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total user time.
        /// </summary>
        [DataMember()]
        public double Time
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total user points.
        /// </summary>
        [DataMember()]
        public int Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user password.
        /// </summary>
        [DataMember(IsRequired = false)]
        public string Password
        {
            get; set;
        }

        #endregion
    }
}
