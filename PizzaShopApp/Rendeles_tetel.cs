using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    class Rendeles_tetel :Pizza
    {
        int db;

        public Rendeles_tetel(int pizzaId, string pizzaNev, int pizzaAr, int db) :base( pizzaId,pizzaNev,pizzaAr)
        {
            this.Db = db;
        }

        public int Db { get => db; set => db = value; }


        public override string ToString()
        {
            return $"{this.PizzaNev} -> {this.Db} db";
        }
    }
}
