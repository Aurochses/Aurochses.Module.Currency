using Aurochses.Module.Currency.Data;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Tests.Fakes.Data
{
    public class FakeCurrencyDbContext : CurrencyDbContext
    {
        public FakeCurrencyDbContext(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions, schemaName)
        {

        }

        public void TestOnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder);
        }
    }
}