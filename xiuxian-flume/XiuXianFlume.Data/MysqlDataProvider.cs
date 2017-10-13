using System.Data.Common;
using XiuXianFlume.Core.Data;

namespace XiuXianFlume.Data
{
    public class MysqlDataProvider : IDataProvider
    {
        public void InitConnectionFactory()
        {
            throw new System.NotImplementedException();
        }

        public void SetDatabaseInitializer()
        {
            throw new System.NotImplementedException();
        }

        public void InitDatabase()
        {
            throw new System.NotImplementedException();
        }

        public bool StoredProceduredSupported { get; }
        public bool BackupSupported { get; }
        public DbParameter GetParameter()
        {
            throw new System.NotImplementedException();
        }

        public int SupportedLengthOfBinaryHash()
        {
            throw new System.NotImplementedException();
        }
    }
}