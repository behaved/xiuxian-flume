using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XiuXianFlume.Core.Infrastructure;
using XiuXianFlume.Core.Data;

namespace XiuXianFlume.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            //initialize engine context
            EngineContext.Initialize(false);

            bool databaseInstalled = DataSettingsHelper.DatabaseIsInstalled();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
