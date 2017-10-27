using Aurochses.Module.Currency.Data;
using Autofac;

namespace Aurochses.Module.Currency.Tests.Fakes.Data
{
    public class FakeDataModule : DataModule
    {
        public void TestLoad(ContainerBuilder builder)
        {
            Load(builder);
        }
    }
}