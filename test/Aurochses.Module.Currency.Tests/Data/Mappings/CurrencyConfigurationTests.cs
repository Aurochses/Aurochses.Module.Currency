using System;
using System.Linq;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Currency.Data.Contract;
using Aurochses.Module.Currency.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Xunit;

namespace Aurochses.Module.Currency.Tests.Data.Mappings
{
    public class CurrencyConfigurationTests
    {
        [Fact]
        public void Inherit_EntityTypeConfiguration()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<EntityTypeConfiguration<CurrencyEntity, int>>(new CurrencyConfiguration("dbo"));
        }

        [Fact]
        public void Map_Entity_Success()
        {
            // Arrange
            const string schemaName = "dbo";
            const string tableName = "Currency";

            var currencyConfiguration = new CurrencyConfiguration(schemaName);

            var modelBuilder = new ModelBuilder(new ConventionSet());
            var entityTypeBuilder = modelBuilder.Entity<CurrencyEntity>();

            // Act
            currencyConfiguration.Map(entityTypeBuilder);

            // Assert
            CheckTable(entityTypeBuilder, schemaName, tableName);
            CheckId(entityTypeBuilder);
            CheckAlphabeticCode(entityTypeBuilder, 3);
        }

        private void CheckTable(EntityTypeBuilder<CurrencyEntity> entityTypeBuilder, string schemaName, string tableName)
        {
            if (schemaName == null) throw new ArgumentNullException(nameof(schemaName));
            if (tableName == null) throw new ArgumentNullException(nameof(tableName));

            var relational = entityTypeBuilder.Metadata.Relational();

            Assert.Equal(schemaName, relational.Schema);
            Assert.Equal(tableName, relational.TableName);
        }

        private void CheckId(EntityTypeBuilder<CurrencyEntity> entityTypeBuilder)
        {
            var property = entityTypeBuilder.Property(x => x.Id);

            Assert.True(property.Metadata.IsPrimaryKey());
            Assert.False(property.Metadata.IsStoreGeneratedAlways);
        }

        private void CheckAlphabeticCode(EntityTypeBuilder<CurrencyEntity> entityTypeBuilder, int maxLength)
        {
            if (maxLength <= 0) throw new ArgumentOutOfRangeException(nameof(maxLength));

            var property = entityTypeBuilder.Property(x => x.AlphabeticCode);

            Assert.False(property.Metadata.IsNullable);
            Assert.Equal(maxLength, property.Metadata.GetMaxLength());

            var indexes = property.Metadata.GetContainingIndexes().ToList();

            Assert.Single(indexes);
            Assert.True(indexes[0].IsUnique);
        }
    }
}