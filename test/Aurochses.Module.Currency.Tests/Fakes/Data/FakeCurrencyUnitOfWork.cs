using System;
using Aurochses.Data;
using Aurochses.Module.Currency.Data;
using Aurochses.Module.Currency.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Tests.Fakes.Data
{
    public class FakeCurrencyUnitOfWork : CurrencyUnitOfWork
    {
        public FakeCurrencyUnitOfWork(Func<DbContext, IRepository<CurrencyEntity, int>> currencyRepository, DbContextOptions dbContextOptions, string schemaName)
            : base(currencyRepository, dbContextOptions, schemaName)
        {

        }
    }
}