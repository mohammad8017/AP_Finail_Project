using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Food
    {
        public string Name { set; get; }
        public int FinishPrice { set; get; }//moshtari
        public int RealPrice { set; get; }
        public string Info { set; get; }
        public string PrivateInfo { set; get; }
        public int Mojoodi { set; get; }
        public string Type { set; get; }
        
        public DateTime date;
        public Food() {; }
        public Food(string Name, int FinishPrice, int RealPrice, string Info, string PrivateInfo,string Type, int Mojoodi, int month, int day, int year)
        {
            this.Name = Name;
            this.FinishPrice = FinishPrice;
            this.RealPrice = RealPrice;
            this.Info = Info;
            this.PrivateInfo = PrivateInfo;
            this.Type = Type;
            this.Mojoodi=Mojoodi;
            date = new DateTime(year, month, day);
        }
        
    }
    public class FoodFactor
    {
        public string Name { set; get; }
        public int FinishPrice { set; get; }
        public int Mojoodi { set; get; }
        public FoodFactor(string Name, int FinishPrice, int Mojoodi)
        {
            this.Name = Name;
            this.FinishPrice = FinishPrice;
            this.Mojoodi = Mojoodi;
        }
    }
    
}
