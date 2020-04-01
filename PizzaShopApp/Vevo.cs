using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    class Vevo
    {
        int id;
        string nev;
        string cim;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }

        public Vevo(int id, string nev, string cim)
        {
            this.id = id;
            this.nev = nev;
            this.cim = cim;
        }
        public override string ToString()
        {
            return this.nev;
        }
    }
}
