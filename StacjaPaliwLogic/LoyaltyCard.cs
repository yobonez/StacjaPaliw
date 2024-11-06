using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwUI
{
    internal class LoyaltyCard
    {
        internal int m_card_id;
        internal string m_id_mtm_cardpromotions;
        internal string m_name;
        internal string m_surname;
        internal int m_points;

        public void Register(string imie, string nazwisko) { 
            m_name = imie;
            m_surname = nazwisko;
        }
        public void Read(int card_id) { 
            m_card_id = card_id;
            // ...
        }
    }
}
