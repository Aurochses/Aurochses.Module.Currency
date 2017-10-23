using Aurochses.Module.Business.Autofac.EntityFrameworkCore;
using Aurochses.Module.Currency.Business;
using Aurochses.Module.Currency.Data.Contract;
using Aurochses.Module.Currency.Tests.Fakes.Business;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Business
{
    public class BusinessModuleTests
    {
        [Fact]
        public void Inherit_BusinessModuleBase()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            // Act
            var businessModule = new BusinessModule(dbContextOptionsBuilder.Options, "dbo");

            // Assert
            Assert.IsAssignableFrom<BusinessModuleBase>(businessModule);
        }

        [Fact]
        public void Load_Success()
        {
            // Arrange
            var containerBuilder = new ContainerBuilder();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();
            var businessModule = new FakeBusinessModule(dbContextOptionsBuilder.Options, "dbo");

            // Act
            businessModule.TestLoad(containerBuilder);

            var container = containerBuilder.Build();

            // Assert
            CheckIfAllTypesRegistered(container);
        }

        internal static void CheckIfAllTypesRegistered(IContainer container)
        {
            Assert.True(container.IsRegistered<ICurrencyUnitOfWork>());
        }
    }
}