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
        public int FinishPrice { set; get; }//moshtari
        public int RealPrice { set; get; }
        public string Info { set; get; }
        public int Mojoodi { set; get; }
        public Food() {; }
        public Food(string Name, int FinishPrice, int RealPrice, string Info, int Mojoodi)
        {
            this.Name = Name;
            this.FinishPrice = FinishPrice;
            this.RealPrice = RealPrice;
            this.Info = Info;
            this.Mojoodi=Mojoodi;
        }
    }
}
