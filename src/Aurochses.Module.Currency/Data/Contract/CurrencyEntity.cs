using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Data.Contract
{
    /// <summary>
    /// Class CurrencyEntity.
    /// </summary>
    /// <seealso>
    ///     <cref>Aurochses.Data.EntityFrameworkCore.EntityNoneDatabaseGeneratedIdentifier{System.Int32}</cref>
    /// </seealso>
    public class CurrencyEntity : EntityNoneDatabaseGeneratedIdentifier<int>
    {
        /// <summary>
        /// Gets or sets the alphabetic code.
        /// </summary>
        /// <value>The alphabetic code.</value>
        public string AlphabeticCode { get; set; }
    }
}