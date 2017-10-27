using Aurochses.Data;
using Aurochses.Module.Currency.Data;
using Aurochses.Module.Currency.Data.Contract;
using Aurochses.Module.Currency.Tests.Fakes.Data;
using Aurochses.Module.Data.Autofac;
using Autofac;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data
{
    public class DataModuleTests
    {
        [Fact]
        public void Inherit_DataModuleBase()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<DataModuleBase>(new DataModule());
        }

        [Fact]
        public void Load_Success()
        {
            // Arrange
            var containerBuilder = new ContainerBuilder();

            var dataModule = new FakeDataModule();

            // Act
            dataModule.TestLoad(containerBuilder);

            var container = containerBuilder.Build();

            // Assert
            CheckIfAllTypesRegistered(container);
        }

        internal static void CheckIfAllTypesRegistered(IContainer container)
        {
            Assert.True(container.IsRegistered<IRepository<CurrencyEntity, int>>());
        }
    }
}