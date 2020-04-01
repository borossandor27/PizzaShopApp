using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    class Rendeles_tetel
    {
        int pizzaId;
        string pizzaNev;
        int pizzaAr;
        int db;

        public Rendeles_tetel(int pizzaId, string pizzaNev, int pizzaAr, int db)
        {
            this.PizzaId = pizzaId;
            this.PizzaNev = pizzaNev;
            this.PizzaAr = pizzaAr;
            this.Db = db;
        }

        public int PizzaId { get => pizzaId; set => pizzaId = value; }
        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public int PizzaAr { get => pizzaAr; set => pizzaAr = value; }
        public int Db { get => db; set => db = value; }

        public override string ToString()
        {
            return this.pizzaNev;
        }
        public string Teteles()
        {
            return $"{this.pizzaNev} -> {this.db} db";
        }
    }
}
