using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data;
using Aurochses.Module.Currency.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data
{
    public class CurrencyUnitOfWorkTests
    {
        private readonly CurrencyUnitOfWork _currencyUnitOfWork;

        public CurrencyUnitOfWorkTests()
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            _currencyUnitOfWork = new CurrencyUnitOfWork(
                dbContext => new Repository<CurrencyEntity, int>(dbContext),
                dbContextOptionsBuilder.Options,
                "dbo"
            );
        }

        [Fact]
        public void Inherit_UnitOfWork()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<UnitOfWork>(_currencyUnitOfWork);
        }

        [Fact]
        public void Inherit_ICurrencyUnitOfWork()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<ICurrencyUnitOfWork>(_currencyUnitOfWork);
        }

        [Fact]
        public void CurrencyRepository_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.IsType<Repository<CurrencyEntity, int>>(_currencyUnitOfWork.CurrencyRepository);
        }
    }
}