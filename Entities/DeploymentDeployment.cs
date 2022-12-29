using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Deployment deployment entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DeploymentDeployment : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DeploymentDeployment()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets parent id.
        /// </summary>
        [DataMember()]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets child id.
        /// </summary>
        [DataMember()]
        public int ChildId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        public virtual Deployment Parent { get; set; }

        /// <summary>
        /// Gets or sets child.
        /// </summary>
        public virtual Deployment Child { get; set; }

        #endregion
    }
}