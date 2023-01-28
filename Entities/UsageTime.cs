using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Usage time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageTime : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time order line id.
        /// </summary>
        [DataMember()]
        public int InvoiceLineId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets product time invoice line.
        /// </summary>
        public virtual InvoiceLineTime InvoiceLine
        {
            get; set;
        }
        #endregion
    }
}