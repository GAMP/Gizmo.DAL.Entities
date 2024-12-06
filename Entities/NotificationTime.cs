#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Notification entity.
    /// </summary>
    public abstract class Notification : ModifiableByOperatorBase , IDisable
    {
        ///<inheritdoc/>
        public bool IsDisabled { get; set; }   
    }    
}
