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
        public int Mojoodi { set; get; }
        public int[] foodDate;
        public DateTime date;
        public Food() {; }
        public Food(string Name, int FinishPrice, int RealPrice, string Info, int Mojoodi, int month, int day, int year)
        {
            this.Name = Name;
            this.FinishPrice = FinishPrice;
            this.RealPrice = RealPrice;
            this.Info = Info;
            this.Mojoodi=Mojoodi;
            foodDate = new int[3];
            foodDate[1] = day;
            foodDate[0] = month;
            foodDate[2] = year;
            date = new DateTime(year, month, day);
        }
    }
}
