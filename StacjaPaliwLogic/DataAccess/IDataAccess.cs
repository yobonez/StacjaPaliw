using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public interface IDataAccess<T>
    {
        public static int _availableId { get; }
        public List<T> GetAllRows();
        public T ReadRow(int _id);
        public void AddRow(T _row);
        public void DeleteRow(int _id);
        public void Save();
    }
}
