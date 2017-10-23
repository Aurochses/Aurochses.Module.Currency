using Aurochses.Module.Autofac.EntityFrameworkCore;
using Aurochses.Module.Currency.Tests.Business;
using Aurochses.Module.Currency.Tests.Data;
using Aurochses.Module.Currency.Tests.Fakes;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Aurochses.Module.Currency.Tests
{
    public class CurrencyModuleTests
    {
        [Fact]
        public void Inherit_ModuleBase()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            // Act
            var currencyModule = new CurrencyModule(dbContextOptionsBuilder.Options, "dbo");

            // Assert
            Assert.IsAssignableFrom<ModuleBase>(currencyModule);
        }

        [Fact]
        public void Load_CurrencyModule_Success()
        {
            // Arrange
            var containerBuilder = new ContainerBuilder();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();
            var currencyModule = new FakeCurrencyModule(dbContextOptionsBuilder.Options);

            // Act
            currencyModule.TestLoad(containerBuilder);

            var container = containerBuilder.Build();

            // Assert
            DataModuleTests.CheckIfAllTypesRegistered(container);
            BusinessModuleTests.CheckIfAllTypesRegistered(container);
        }
    }
}