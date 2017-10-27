using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data.Contract;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data.Contract
{
    public class CurrencyEntityTests
    {
        [Fact]
        public void Inherit_EntityNoneDatabaseGeneratedIdentifier()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<EntityNoneDatabaseGeneratedIdentifier<int>>(new CurrencyEntity());
        }

        [Fact]
        public void AlphabeticCode_Get_Success()
        {
            // Arrange
            var currencyEntity = new CurrencyEntity();

            // Act & Assert
            Assert.True(string.IsNullOrEmpty(currencyEntity.AlphabeticCode));
        }

        [Fact]
        public void AlphabeticCode_Set_Success()
        {
            // Arrange
            const string alphabeticCode = "USD";

            // Act
            var currencyEntity = new CurrencyEntity
            {
                AlphabeticCode = alphabeticCode
            };

            // Assert
            Assert.Equal(alphabeticCode, currencyEntity.AlphabeticCode);
        }
    }
}