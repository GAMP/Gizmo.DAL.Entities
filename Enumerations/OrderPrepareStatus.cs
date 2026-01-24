namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Order preparation status.
    /// </summary>
    public enum OrderPrepareStatus
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Unprepared.
        /// </summary>
        Unprepared = 1,
    
        /// <summary>
        /// Preparing.
        /// </summary>
        Preparing = 2,

        /// <summary>
        /// Prepared.
        /// </summary>
        Prepared = 3,
    }
}
