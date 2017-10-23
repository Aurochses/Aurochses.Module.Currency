using Aurochses.Module.Currency.Business.Contract;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Business.Contract
{
    public class CurrencyDtoTests
    {
        [Fact]
        public void Inherit_ICurrencyDto()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<ICurrencyDto>(new CurrencyDto());
        }

        [Fact]
        public void Id_Get_Success()
        {
            // Arrange
            var item = new CurrencyDto();

            // Act & Assert
            Assert.Equal(0, item.Id);
        }

        [Fact]
        public void Id_Set_Success()
        {
            // Arrange
            const int id = 1;

            // Act
            var item = new CurrencyDto
            {
                Id = id
            };

            // Assert
            Assert.Equal(id, item.Id);
        }

        [Fact]
        public void AlphabeticCode_Get_Success()
        {
            // Arrange
            var item = new CurrencyDto();

            // Act & Assert
            Assert.Null(item.AlphabeticCode);
        }

        [Fact]
        public void AlphabeticCode_Set_Success()
        {
            // Arrange
            const string alphabeticCode = "USD";

            // Act
            var item = new CurrencyDto
            {
                AlphabeticCode = alphabeticCode
            };

            // Assert
            Assert.Equal(alphabeticCode, item.AlphabeticCode);
        }
    }
}