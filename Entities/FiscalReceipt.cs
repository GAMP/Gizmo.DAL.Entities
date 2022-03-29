using GizmoDALV2.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt entity.
    /// </summary>
    public class FiscalReceipt : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceipt() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets receipt type.
        /// </summary>
        /// <remarks>
        /// Indicates fiscal receipt type. For example pay or return (still in cosnideration).
        /// </remarks>
        public int Type
        {
            get;set;
        }
        
        /// <summary>
        /// Gets or sets receipt status.
        /// </summary>
        public int Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets document id.
        /// </summary>
        public int? DocumentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets signature.
        /// </summary>
        public string Signature
        {
            get; set;
        } 

        #endregion
    }
}
