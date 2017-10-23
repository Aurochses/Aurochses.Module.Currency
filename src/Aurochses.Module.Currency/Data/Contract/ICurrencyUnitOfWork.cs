using Aurochses.Data;

namespace Aurochses.Module.Currency.Data.Contract
{
    /// <summary>
    /// Interface ICurrencyUnitOfWork
    /// </summary>
    /// <seealso cref="Aurochses.Data.IUnitOfWork" />
    public interface ICurrencyUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets the currency repository.
        /// </summary>
        /// <value>The currency repository.</value>
        IRepository<CurrencyEntity, int> CurrencyRepository
        {
            get;
        }
    }
}