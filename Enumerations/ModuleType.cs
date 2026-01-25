namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Application module type.
    /// </summary>
    public enum ModuleType
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// Manager.
        /// </summary>
        Manager = 1,
        
        /// <summary>
        /// Client.
        /// </summary>
        Client = 2,
        
        /// <summary>
        /// Service.
        /// </summary>
        Service = 4,
        
        /// <summary>
        /// Any.
        /// </summary>
        Any = Manager | Client | Service,
    }
}
