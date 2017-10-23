using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Data
{
    /// <summary>
    /// Class CurrencyDbContext.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.DbContextBase" />
    public class CurrencyDbContext : DbContextBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDbContext"/> class.
        /// </summary>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public CurrencyDbContext(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions, schemaName)
        {

        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.</remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new CurrencyConfiguration(SchemaName));
        }
    }
}