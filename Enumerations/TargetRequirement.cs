namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Source list requirements.
    /// </summary>
    public enum TargetRequirement
    {
        /// <summary>
        /// All items in list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer purchase all target products.
        /// </remarks>
        All = 0,

        /// <summary>
        /// Any of items in list.
        /// </summary>
        /// <remarks>
        /// This can also be considered as one of.
        /// This rule basically requires that customer purchase at least one of the target products.
        /// </remarks>
        Any = 1,

        /// <summary>
        /// Specific amount of items in the list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer purchase at least the amount of target products.
        /// </remarks>
        Count = 2,

        /// <summary>
        /// Mnium amount spent on target list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer spend at least amount on target products.
        /// </remarks>
        Amount = 3,
    }
}
