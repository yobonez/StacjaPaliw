﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class LoyaltyCard
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int points { get; set; }

        public LoyaltyCard() { }
        public LoyaltyCard(int _id, string _name, string _surname, int _points)
        {
            id = _id;
            name = _name;
            surname = _surname;
            points = _points;
        }
    }
}
