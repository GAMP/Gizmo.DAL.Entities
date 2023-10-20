using ProtoBuf;

using SharedLib;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Period date base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class PeriodDate : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PeriodDate() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets flags.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public PeriodOptionType Options
        {
            get;
            set;
        }

        #endregion
    }
}