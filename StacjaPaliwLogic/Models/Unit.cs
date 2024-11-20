using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string name { get; set; }

        public Unit() { }
        public Unit(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
    }
}
