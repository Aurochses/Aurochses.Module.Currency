using Aurochses.Module.Currency.Business.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Business.Contract
{
    // ReSharper disable once InconsistentNaming
    public class ICurrencyDtoTests
    {
        [Fact]
        public void Id_Get_Success()
        {
            // Arrange
            const int id = 1;

            var mockItem = new Mock<ICurrencyDto>(MockBehavior.Strict);
            mockItem.SetupGet(m => m.Id).Returns(id);

            // Act & Assert
            Assert.Equal(id, mockItem.Object.Id);
        }

        [Fact]
        public void Id_Set_Success()
        {
            // Arrange
            var result = 0;

            const int id = 1;

            var mockItem = new Mock<ICurrencyDto>(MockBehavior.Strict);
            mockItem.SetupSet(m => m.Id = It.IsAny<int>()).Callback((int value) => { result = value; });

            // Act
            mockItem.Object.Id = id;

            // Assert
            Assert.Equal(id, result);
        }

        [Fact]
        public void AlphabeticCode_Get_Success()
        {
            // Arrange
            const string alphabeticCode = "USD";

            var mockItem = new Mock<ICurrencyDto>(MockBehavior.Strict);
            mockItem.SetupGet(m => m.AlphabeticCode).Returns(alphabeticCode);

            // Act & Assert
            Assert.Equal(alphabeticCode, mockItem.Object.AlphabeticCode);
        }

        [Fact]
        public void AlphabeticCode_Set_Success()
        {
            // Arrange
            var result = string.Empty;

            const string alphabeticCode = "USD";

            var mockItem = new Mock<ICurrencyDto>(MockBehavior.Strict);
            mockItem.SetupSet(m => m.AlphabeticCode = It.IsAny<string>()).Callback((string value) => { result = value; });

            // Act
            mockItem.Object.AlphabeticCode = alphabeticCode;

            // Assert
            Assert.Equal(alphabeticCode, result);
        }
    }
}