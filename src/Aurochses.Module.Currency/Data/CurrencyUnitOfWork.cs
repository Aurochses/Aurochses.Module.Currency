using System;
using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Data
{
    /// <summary>
    /// Class CurrencyUnitOfWork.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.UnitOfWork" />
    /// <seealso cref="Aurochses.Module.Currency.Data.Contract.ICurrencyUnitOfWork" />
    public class CurrencyUnitOfWork : UnitOfWork, ICurrencyUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyUnitOfWork"/> class.
        /// </summary>
        /// <param name="currencyRepository">The currency repository.</param>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public CurrencyUnitOfWork(
            Func<DbContext, IRepository<CurrencyEntity, int>> currencyRepository,
            DbContextOptions dbContextOptions,
            string schemaName)
            : base(new CurrencyDbContext(dbContextOptions, schemaName))
        {
            RegisterRepository(currencyRepository(DbContext));
        }

        /// <summary>
        /// Gets the currency repository.
        /// </summary>
        /// <value>The currency repository.</value>
        public IRepository<CurrencyEntity, int> CurrencyRepository => GetRepository<CurrencyEntity, int>();
    }
}