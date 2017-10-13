using System;
using System.Collections.Generic;

namespace XiuXianFlume.Core.Data
{
    /// <summary>
    /// data settings(connection string information)
    /// </summary>
    public partial class DataSettings
    {
        public DataSettings()
        {
            RawDataSettings = new Dictionary<string, string>();
        }

        /// <summary>
        /// data provider
        /// </summary>
        public string DataProvider { get; set; }
        
        /// <summary>
        /// connection string
        /// </summary>
        public string DataConnectionString { get; set; }
        
        /// <summary>
        /// Raw setting file
        /// </summary>
        public IDictionary<string,string> RawDataSettings { get; private set; }

        /// <summary>
        /// A value indicating whether entered information is valid
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(DataProvider) && !string.IsNullOrEmpty(DataConnectionString);
        }
    }
}