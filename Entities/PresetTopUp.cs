namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Preset top up.
    /// </summary>
    public sealed class PresetTopUp : ValueBase<decimal>, IDisplayOrder
    {
        ///<inheritdoc/>
        public int DisplayOrder { get; set; }
    }
}
