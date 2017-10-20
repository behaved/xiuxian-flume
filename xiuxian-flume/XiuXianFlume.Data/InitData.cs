using System;
using System.Data.Entity;

namespace XiuXianFlume.Data
{
    public class InitData : CreateDatabaseIfNotExists<XiuXianObjectContext>
    {
        /// <summary>
        /// init database
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(XiuXianObjectContext context)
        {
            
        }
    }
}