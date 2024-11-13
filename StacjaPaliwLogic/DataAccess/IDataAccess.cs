using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public interface IDataAccess<T>
    {
        public List<T> GetAllRows();
        public T ReadRow(int id);
        public void AddRow(T row);
        public void DeleteRow(T row);
        public void SaveToJsonFile();
    }
}
