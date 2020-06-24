using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class boss
    {
        public string Name { set; get; }
        public string Family { set; get; }
        public string Pass { set; get; }
        public int Code { set; get; }
        public int Region { set; get; }
        public string Address { set; get; }
        public string TypeOfRestaurant { set; get; }
        public int hazine = 0;
        public int daramad = 0;
        public boss() {; }
        public boss(string name, string family, int code, string pass, string address, int region, string type)
        {
            this.Name = name;
            this.Family = family;
            this.Code = code;
            this.Pass = pass;
            this.Address = address;
            this.Region = region;
            this.TypeOfRestaurant = type;
        }
    }
}
