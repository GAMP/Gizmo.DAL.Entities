using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Usage session.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class UsageSession : EntityBase, IModifiable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageSession() : base()
        {
            Usage = new HashSet<Usage>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current usage id.
        /// </summary>
        [DataMember()]
        public int? CurrentUsageId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current second.
        /// </summary>
        [DataMember()]
        public double CurrentSecond
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount of negative seconds in this usage session.
        /// </summary>
        [DataMember()]
        public double NegativeSeconds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start fee.
        /// </summary>
        [DataMember()]
        public decimal StartFee
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets minimum fee.
        /// </summary>
        [DataMember()]
        public decimal MinimumFee
        {
            get; set;
        }

        /// <summary>
        /// Gets total amount charged in rate.
        /// </summary>
        [DataMember()]
        public decimal RatesTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if session is active.
        /// </summary>
        [DataMember()]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or set modified time.
        /// </summary>
        [DataMember()]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        public DateTime CreatedTime
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current usage.
        /// </summary>
        public virtual Usage CurrentUsage
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<Usage> Usage
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLineSession> InvoiceLines
        {
            get; set;
        }

        #endregion
    }
}