using Aurochses.Module.Currency.Business.Contract;
using Aurochses.Module.Currency.Data.Contract;

namespace Aurochses.Module.Currency.Business
{
    /// <summary>
    /// Class CurrencyService.
    /// </summary>
    /// <seealso cref="ICurrencyService" />
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public CurrencyService(ICurrencyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Insert.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Insert(ICurrencyDto item)
        {
            var entity = new CurrencyEntity
            {
                Id = item.Id,
                AlphabeticCode = item.AlphabeticCode
            };

            _unitOfWork.CurrencyRepository.Insert(entity);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Update.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Update(ICurrencyDto item)
        {
            var entity = new CurrencyEntity
            {
                Id = item.Id,
                AlphabeticCode = item.AlphabeticCode
            };

            _unitOfWork.CurrencyRepository.Update(entity);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            _unitOfWork.CurrencyRepository.Delete(id);
            _unitOfWork.Commit();
        }
    }
}