using System.Data.Common;
using System.Data.Entity;
using MySql.Data.Entity;
using XiuXianFlume.Core.Data;

namespace XiuXianFlume.Data
{
    public class MysqlDataProvider : IDataProvider
    {
        public MysqlDataProvider()
        {
            StoredProceduredSupported = false;
            BackupSupported = false;
        }

        public void InitConnectionFactory()
        {
            var connectionFactory = new MySqlConnectionFactory();
            #pragma warning disable 618
            Database.DefaultConnectionFactory = connectionFactory;            
            #pragma warning restore 618
        }

        public void SetDatabaseInitializer()
        {
            
            Database.SetInitializer(new InitData());
        }

        public void InitDatabase()
        {
            InitConnectionFactory();
            SetDatabaseInitializer();
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