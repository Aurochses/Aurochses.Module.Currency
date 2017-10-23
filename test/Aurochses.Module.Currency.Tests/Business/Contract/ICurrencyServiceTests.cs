using Aurochses.Module.Currency.Business.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Business.Contract
{
    // ReSharper disable once InconsistentNaming
    public class ICurrencyServiceTests
    {
        [Fact]
        public void Insert_Success()
        {
            // Arrange
            var mockCurrencyDto = new Mock<ICurrencyDto>(MockBehavior.Strict);

            var mockCurrencyService = new Mock<ICurrencyService>(MockBehavior.Strict);
            mockCurrencyService.Setup(m => m.Insert(mockCurrencyDto.Object)).Verifiable();

            // Act
            mockCurrencyService.Object.Insert(mockCurrencyDto.Object);

            // Assert
            mockCurrencyService.Verify();
        }

        [Fact]
        public void Update_Success()
        {
            // Arrange
            var mockCurrencyDto = new Mock<ICurrencyDto>(MockBehavior.Strict);

            var mockCurrencyService = new Mock<ICurrencyService>(MockBehavior.Strict);
            mockCurrencyService.Setup(m => m.Update(mockCurrencyDto.Object)).Verifiable();

            // Act
            mockCurrencyService.Object.Update(mockCurrencyDto.Object);

            // Assert
            mockCurrencyService.Verify();
        }

        [Fact]
        public void Delete_Success()
        {
            // Arrange
            var mockCurrencyService = new Mock<ICurrencyService>(MockBehavior.Strict);
            mockCurrencyService.Setup(m => m.Delete(1)).Verifiable();

            // Act
            mockCurrencyService.Object.Delete(1);

            // Assert
            mockCurrencyService.Verify();
        }
    }
}