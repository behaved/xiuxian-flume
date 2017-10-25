using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XiuXianFlume.Core.Infrastructure;
using XiuXianFlume.Core.Data;
using XiuXianFlume.Data;
using XiuXianFlume.Core;
using XiuXianFlume.Core.Domain;

namespace XiuXianFlume.Tests
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ca = new User
            {
                Name = "Name HHH",
                Password = "******",
                Phone = "555",
                Remark = "哈哈哈"
            };

            var fromDb = SaveAndLoadEntity(ca);
            Assert.IsNotNull(fromDb);
            Assert.AreEqual(fromDb.Name,ca.Name);
        }
    }
}
