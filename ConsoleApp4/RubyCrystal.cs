using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class BFSword : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public BFSword()
        {
            //ustalamy nazwe itemu
            name = "BFSword";
            // jego cene
            price = 1300;
            //i atrybuty
            AddStat(Stat.AD, 40);
        }
    }
}
