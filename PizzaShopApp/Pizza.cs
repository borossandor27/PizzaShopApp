using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PizzaShopApp
{
    class Pizza
    {
        int pizzaId;
        string pizzaNev;
        int pizzaAr;
        Image pizzaKep;

        public Pizza(int pizzaId, string pizzaNev, int pizzaAr)
        {
            this.PizzaId = pizzaId;
            this.PizzaNev = pizzaNev;
            this.PizzaAr = pizzaAr;
            string kep = @"Resources\Pizza_" + this.PizzaNev + ".png";
            if (File.Exists(kep))
            {
                this.PizzaKep = Image.FromFile(kep);
            }

        }

        public int PizzaId { get => pizzaId; set => pizzaId = value; }
        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public int PizzaAr { get => pizzaAr; set => pizzaAr = value; }
        public Image PizzaKep { get => pizzaKep; set => pizzaKep = value; }

        public override string ToString()
        {
            return this.pizzaNev;
        }

    }
}
