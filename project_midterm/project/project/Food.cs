using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Food
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public string Info { set; get; }
        public int Mojoodi { set; get; }
        public Food() {; }
        public Food(string Name, int Price, string Info, int Mojoodi)
        {
            this.Name = Name;
            this.Price = Price;
            this.Info = Info;
            this.Mojoodi = Mojoodi;
        }
    }
}
