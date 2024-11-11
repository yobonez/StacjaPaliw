using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public interface IDataAccess<T>
    {
        public List<T> Load();
        public T Read();
        public void Add(T row); // add + save to table
    }
}
