using System;
using XiuXianFlume.Core;
using XiuXianFlume.Core.Data;

namespace XiuXianFlume.Data
{
    public class EfDataProviderManager : BaseDataProviderManager
    {
        public EfDataProviderManager(DataSettings settings):base(settings)
        {
        }

        public override IDataProvider LoadDataProvider()
        {
            var providerName = Settings.DataProvider;
            if (string.IsNullOrWhiteSpace(providerName))
                throw new XiuXianException("Data Settings doesn't contain a providerName");

            switch (providerName.ToLowerInvariant())
            {
                case "mysql":
                    return new MysqlDataProvider();
                default:
                    throw new XiuXianException(string.Format("Not supported dataprovider name: {0}", providerName));
            }
        }
    }
}