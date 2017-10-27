using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Currency.Data.Mappings
{
    /// <summary>
    /// Class CurrencyConfiguration.
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{Aurochses.Module.Currency.Data.Contract.CurrencyEntity, System.Int32}
    ///     </cref>
    /// </seealso>
    public class CurrencyConfiguration : EntityTypeConfiguration<CurrencyEntity, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public CurrencyConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<CurrencyEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("Currency", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.AlphabeticCode).IsRequired().HasMaxLength(3);

            // Index
            entityTypeBuilder.HasIndex(x => x.AlphabeticCode).IsUnique();
        }
    }
}