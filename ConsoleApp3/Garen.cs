using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * Klasa dziedzicząca po ogólnej klasie champion opisująca konkretnego champa - garena
     */
    class Garen : Champion
    {
        /*
         * Konstruktor
         */
        public Garen()
        {
            //przypisz imie
            name = "Garen";
            //ustaw poczatkowe hp
            hp = 2282;
            maxHp = 2282;
            ad = 149;
            ap = 0;
            mana = 900;
            maxMana = 900;
            //wyświetl komunikat
            Console.WriteLine("Konstruktor klasy Garen");
        }
        /*
         * funkcja specyficzna dla Garena - emotka pod klawiszem ctrl+3
         */
        public void ctrl3()
        {
            Console.WriteLine("Garen tańczy!");
        }


    }
}
