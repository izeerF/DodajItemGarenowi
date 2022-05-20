using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisuj¹ca konkretny rodzaj itemu w sklepie
     */
    public class Rabadon : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public Rabadon()
        {
            //ustalamy nazwe itemu
            name = "Rabadon's Deathcap";
            // jego cene
            price = 3600;
            //i atrybuty
            AddStat(Stat.AP, 120);
        }
    }
}
