using Aurochses.Data;
using Aurochses.Module.Currency.Data.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data.Contract
{
    // ReSharper disable once InconsistentNaming
    public class ICurrencyUnitOfWorkTests
    {
        [Fact]
        public void Inherit_IUnitOfWork()
        {
            // Arrange
            var mockCurrencyUnitOfWork = new Mock<ICurrencyUnitOfWork>(MockBehavior.Strict);

            // Act & Assert
            Assert.IsAssignableFrom<IUnitOfWork>(mockCurrencyUnitOfWork.Object);
        }

        [Fact]
        public void CurrencyRepository_Get_Success()
        {
            // Arrange
            var mockCurrencyRepository = new Mock<IRepository<CurrencyEntity, int>>(MockBehavior.Strict);

            var mockCurrencyUnitOfWork = new Mock<ICurrencyUnitOfWork>(MockBehavior.Strict);
            mockCurrencyUnitOfWork.SetupGet(m => m.CurrencyRepository).Returns(mockCurrencyRepository.Object);

            // Act & Assert
            Assert.Equal(mockCurrencyRepository.Object, mockCurrencyUnitOfWork.Object.CurrencyRepository);
        }
    }
}