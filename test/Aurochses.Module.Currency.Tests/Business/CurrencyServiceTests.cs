using Aurochses.Data;
using Aurochses.Module.Currency.Business;
using Aurochses.Module.Currency.Business.Contract;
using Aurochses.Module.Currency.Data.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Business
{
    public class CurrencyServiceTests
    {
        [Fact]
        public void Inherit_ICurrencyService()
        {
            // Arrange & Act
            var mockUnitOfWork = new Mock<ICurrencyUnitOfWork>();

            // Assert
            Assert.IsAssignableFrom<ICurrencyService>(new CurrencyService(mockUnitOfWork.Object));
        }

        [Fact]
        public void Insert_NewEntity_Inserted()
        {
            // Arrange
            const int id = 840;
            const string alphabeticCode = "USD";

            var mockRepository = new Mock<IRepository<CurrencyEntity, int>>(MockBehavior.Strict);
            mockRepository.Setup(x => x.Insert(new CurrencyEntity { Id = id, AlphabeticCode = alphabeticCode })).Returns(new CurrencyEntity()).Verifiable();

            var mockUnitOfWork = new Mock<ICurrencyUnitOfWork>(MockBehavior.Strict);
            mockUnitOfWork.SetupGet(x => x.CurrencyRepository).Returns(mockRepository.Object);
            mockUnitOfWork.Setup(x => x.Commit()).Returns(1).Verifiable();

            var service = new CurrencyService(mockUnitOfWork.Object);

            var item = new CurrencyDto
            {
                Id = id,
                AlphabeticCode = alphabeticCode
            };

            // Act
            service.Insert(item);

            // Assert
            mockRepository.Verify();
            mockUnitOfWork.Verify();
        }

        [Fact]
        public void Update_Entity_Updated()
        {
            // Arrange
            const int id = 840;
            const string alphabeticCode = "USD";

            var mockRepository = new Mock<IRepository<CurrencyEntity, int>>(MockBehavior.Strict);
            mockRepository.Setup(x => x.Update(new CurrencyEntity { Id = id, AlphabeticCode = alphabeticCode }, false)).Returns(new CurrencyEntity()).Verifiable();

            var mockUnitOfWork = new Mock<ICurrencyUnitOfWork>(MockBehavior.Strict);
            mockUnitOfWork.SetupGet(x => x.CurrencyRepository).Returns(mockRepository.Object);
            mockUnitOfWork.Setup(x => x.Commit()).Returns(1).Verifiable();

            var service = new CurrencyService(mockUnitOfWork.Object);

            var item = new CurrencyDto
            {
                Id = id,
                AlphabeticCode = alphabeticCode
            };

            // Act
            service.Update(item);

            // Assert
            mockRepository.Verify();
            mockUnitOfWork.Verify();
        }

        [Fact]
        public void Delete_NewEntity_Success()
        {
            // Arrange
            const int id = 840;

            var mockRepository = new Mock<IRepository<CurrencyEntity, int>>(MockBehavior.Strict);
            mockRepository.Setup(x => x.Get(It.IsAny<QueryParameters<CurrencyEntity, int>>())).Returns(new CurrencyEntity { Id = id });
            mockRepository.Setup(x => x.Delete(It.Is<CurrencyEntity>(entity => entity.Id == id))).Verifiable();

            var mockUnitOfWork = new Mock<ICurrencyUnitOfWork>(MockBehavior.Strict);
            mockUnitOfWork.SetupGet(x => x.CurrencyRepository).Returns(mockRepository.Object);
            mockUnitOfWork.Setup(x => x.Commit()).Returns(1).Verifiable();

            var service = new CurrencyService(mockUnitOfWork.Object);

            // Act
            service.Delete(id);

            // Assert
            mockRepository.Verify();
            mockUnitOfWork.Verify();
        }
    }
}