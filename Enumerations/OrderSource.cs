namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Client order source.
    /// </summary>
    public enum OrderSource
    {
        /// <summary>
        /// Default. (POS)
        /// </summary>
        Default = 0,
        
        /// <summary>
        /// Client machine.
        /// </summary>
        Client = 1,

        /// <summary>
        /// Web portal.
        /// </summary>
        Web = 2,
    }
}
