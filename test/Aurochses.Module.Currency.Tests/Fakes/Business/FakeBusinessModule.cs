using Aurochses.Module.Currency.Business;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Tests.Fakes.Business
{
    public class FakeBusinessModule : BusinessModule
    {
        public FakeBusinessModule(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions, schemaName)
        {

        }

        public void TestLoad(ContainerBuilder builder)
        {
            Load(builder);
        }
    }
}