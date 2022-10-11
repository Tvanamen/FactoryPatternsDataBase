using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsDataBase
{
     static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databasetype)
        {
            switch (databasetype.ToLower())
            {
                case "list":
                case "regular":
                    return new ListDataAccess();

                case "mysql":
                case "sql":
                case "my":
                    return new SQLDataAccess();

                case "mongo":
                    return new MongoDataAccess();
                    
                default:
                    return new ListDataAccess();
                    
            }
        }
    }
}
