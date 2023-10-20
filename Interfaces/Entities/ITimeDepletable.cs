namespace Gizmo.DAL
{
    /// <summary>
    /// ITimeDepletable interface.
    /// </summary>
    public interface ITimeDepletable
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets depleted state.
        /// </summary>
        bool IsDepleted { get; set; }

        #endregion
    }
}