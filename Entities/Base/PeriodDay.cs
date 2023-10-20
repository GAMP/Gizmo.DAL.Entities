using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Period day base class.
    /// </summary>
    [Serializable()]
    [DataContract]
    [ProtoContract()]
    public abstract class PeriodDay : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PeriodDay() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets day of week.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DayOfWeek Day
        {
            get;
            set;
        }

        #endregion
    }
}