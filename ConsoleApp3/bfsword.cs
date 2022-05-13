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
    public class BFSword : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public BFSword()
        {
            //ustalamy nazwe itemu
            name = "B. F. Sword";
            // jego cene
            price = 1300;
            //i atrybuty
            AddStat(Stat.AD, 40);
        }
    }
}
