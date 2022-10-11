using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsDataBase
{
    public interface IDataAccess
    {
        public void SaveData();
       public List<Product> LoadData();
       
    }
}
