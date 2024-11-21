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
        public Unit(string _name)
        {
            name = _name;
        }
    }
}
