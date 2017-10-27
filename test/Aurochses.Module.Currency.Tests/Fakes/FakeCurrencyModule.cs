using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Currency.Tests.Fakes
{
    public class FakeCurrencyModule : CurrencyModule
    {
        public FakeCurrencyModule(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public void TestLoad(ContainerBuilder builder)
        {
            Load(builder);
        }
    }
}