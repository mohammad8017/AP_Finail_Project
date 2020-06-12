using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace project
{
    public class Customer
    {
        public List<Customer> customer = new List<Customer>();
        public string Name { set; get; }
        public string Family { set; get; }
        public double PhoneNum { set; get; }
        public string Email { set; get; }
        public string NationalCode { set; get; }
        public string Pass { set; get; }
        public Customer() {; }
        public Customer(string name, string family, double phoneNum, string email, string nationalCode, string pass)
        {
            this.Name = name;
            this.Family = family;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.NationalCode = nationalCode;
            this.Pass = pass;
        }
        public bool isValidEmail()
        {

            // This Pattern is use to verify the email 
            string temp = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex check = new Regex(temp, RegexOptions.IgnoreCase);

            if (check.IsMatch(Email))
                return (true);
            else
                return (false);
        }
    }
}
