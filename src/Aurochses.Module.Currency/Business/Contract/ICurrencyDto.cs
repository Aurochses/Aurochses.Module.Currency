namespace Aurochses.Module.Currency.Business.Contract
{
    /// <summary>
    /// Interface ICurrencyDto
    /// </summary>
    public interface ICurrencyDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the alphabetic code.
        /// </summary>
        /// <value>The alphabetic code.</value>
        string AlphabeticCode { get; set; }
    }
}