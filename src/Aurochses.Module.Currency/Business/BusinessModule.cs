using System.Collections.Generic;
using Autofac;
using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using Aurochses.Module.Business.Autofac.EntityFrameworkCore;
using Aurochses.Module.Currency.Data;
using Aurochses.Module.Currency.Data.Contract;

namespace Aurochses.Module.Currency.Business
{
    /// <summary>
    /// Class BusinessModule.
    /// </summary>
    /// <seealso cref="Aurochses.Module.Business.Autofac.EntityFrameworkCore.BusinessModuleBase" />
    public class BusinessModule : BusinessModuleBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessModule"/> class.
        /// </summary>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public BusinessModule(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions, schemaName)
        {

        }

        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>Note that the ContainerBuilder parameter is unique to this module.</remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CurrencyUnitOfWork>().As<ICurrencyUnitOfWork>()
                .WithParameters(
                    new List<Parameter>
                    {
                        new NamedParameter(DbContextOptionsParameter, DbContextOptions),
                        new NamedParameter(SchemaNameParameter, SchemaName)
                    })
                .InstancePerLifetimeScope();
        }
    }
}