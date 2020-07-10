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
        public List<FactorList> factors = new List<FactorList>();
        public List<Food> sabad = new List<Food>();
        public bool laghveKharid = false;
        public bool ghoreKeshi = false;
        public double HesabNum;
        public string Emza;
        public string Name { set; get; }
        public string Family { set; get; }
        public double PhoneNum { set; get; }
        public string Email { set; get; }
        public string NationalCode { set; get; }
        public string Pass { set; get; }
        public int NumSignIn = 0;

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
        public bool IsPhoneNumber(string number)
        {
            if (Regex.Match(number, @"^(\+[0-9]{10})$").Success || number.StartsWith("09") || number.StartsWith("9") || number.StartsWith("+989") || number.StartsWith("00989"))
            {
                return true;
            }
            else
                return false;
            //return Regex.Match(number, @"^(\+[0-9]{10})$").Success;
        }
        public bool checkNationalId(string str)
        {
            int[] code = new int[10];

            for (int i = 0; i < 10; i++)
            {
                code[i] = int.Parse(str[0].ToString());
            }
            int a = code[9];
            int b = code[0] * 10 + code[1] * 9 + code[2] * 8 + code[3] * 7 + code[4] * 6 + code[5] * 5 + code[6] * 4 + code[7] * 3 + code[8] * 2;
            int c = b % 11;
            if (c == 0 && a == c)
            {
                return true;
            }
            else if (c == 1 && a == 1)
            {
                return true;
            }
            else if (str == "9999999999")
            {
                return false;
            }
            else if (c > 1 && a == 11 - c)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsValidPass(string pass)
        {
            //No white space
            if (pass.Contains(" "))
                return false;
            //At least 1 upper case letter
            if (!pass.Any(char.IsUpper))
                return false;
            //At least 1 lower case letter
            if (!pass.Any(char.IsLower))
                return false;

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (pass.Contains(c))
                    return true;
            }
            return false;
        }
        public bool IsValidName(string name)
        {
            if (name.Contains(" "))
                return false;

            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (name.Contains(c))
                    return false;
            }
            return true;
        }
    }
}
