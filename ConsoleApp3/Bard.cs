using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    class Bard : Champion
    {

        public Bard()
        {
            name = "Bard";
            hp = 2073;
            maxHp = 2073;
            ad = 103;
            ap = 0;
            mana = 1200;
            maxMana = 1200;
        }
        public void Q(Champion enemy)
        {
            float manaCost = 60;
            float md = 260 + ap * 0.65f;
            float cd = 7;
            float ccDuration = 1.8f;
            ccType cc = ccType.slow;
            mana = mana - manaCost;
            Console.WriteLine("Bard po uzyciu Q ma teraz: " + mana.ToString()+"/"+maxMana.ToString() + "many");
            enemy.hp = enemy.hp - md;
            Console.WriteLine("Bard zadal " + enemy.name +" "+ md.ToString() + " obrazen");
            Console.WriteLine(enemy.name + " ma teraz " + enemy.hp.ToString()+"/"+enemy.maxHp.ToString() + "hp");
        }
        public void W(Champion ally)
        {
            float manaCost = 70;
            float cd = 14;
            float healAmount = 150 + ap * 0.3f;
            mana = mana - manaCost;
        }
        public void E()
        {
            float manaCost = 30;
            float cd = 16;
            mana = mana - manaCost;
        }
        public void R(Champion enemy)
        {
            float manaCost = 100;
            float cd = 80;
            float ccDuration = 2.5f;
            ccType cc = ccType.statis;
            mana = mana - manaCost;
        }


    }
}
