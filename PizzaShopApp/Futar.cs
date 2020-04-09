using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    class Futar
    {
        int id;
        string nev;
        string telefon;

        public Futar(int id, string nev, string telefon)
        {
            this.Id = id;
            this.Nev = nev;
            this.Telefon = telefon;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return nev;
        }
    }
}
