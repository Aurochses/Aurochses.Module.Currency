namespace Aurochses.Module.Currency.Business.Contract
{
    /// <summary>
    /// Class CurrencyDto.
    /// </summary>
    /// <seealso cref="Aurochses.Module.Currency.Business.Contract.ICurrencyDto" />
    public class CurrencyDto : ICurrencyDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the alphabetic code.
        /// </summary>
        /// <value>The alphabetic code.</value>
        public string AlphabeticCode { get; set; }
    }
}