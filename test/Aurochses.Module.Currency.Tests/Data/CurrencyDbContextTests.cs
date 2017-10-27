using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data;
using Aurochses.Module.Currency.Data.Contract;
using Aurochses.Module.Currency.Tests.Fakes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data
{
    public class CurrencyDbContextTests
    {
        [Fact]
        public void Inherit_DbContextBase()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            // Act & Assert
            Assert.IsAssignableFrom<DbContextBase>(new CurrencyDbContext(dbContextOptionsBuilder.Options, "dbo"));
        }

        [Fact]
        public void OnModelCreating_CurrencyDbContext_Success()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            var dbContext = new FakeCurrencyDbContext(dbContextOptionsBuilder.Options, "dbo");

            var modelBuilder = new ModelBuilder(new ConventionSet());

            // Act
            dbContext.TestOnModelCreating(modelBuilder);

            // Assert
            Assert.NotNull(modelBuilder.Model.FindEntityType(typeof (CurrencyEntity)));
        }
    }
}