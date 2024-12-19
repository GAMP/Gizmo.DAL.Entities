namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Age restriction product.
    /// </summary>
    public sealed class AgeRestrictionProduct : AgeRestriction
    {
        /// <summary>
        /// Gest or sets product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public ProductBase Product { get; set; }
    }
}
