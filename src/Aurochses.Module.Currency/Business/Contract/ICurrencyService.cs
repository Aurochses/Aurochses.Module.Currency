namespace Aurochses.Module.Currency.Business.Contract
{
    /// <summary>
    /// Interface ICurrencyService
    /// </summary>
    public interface ICurrencyService
    {
        /// <summary>
        /// Insert.
        /// </summary>
        /// <param name="item">The item.</param>
        void Insert(ICurrencyDto item);

        /// <summary>
        /// Update.
        /// </summary>
        /// <param name="item">The item.</param>
        void Update(ICurrencyDto item);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);
    }
}