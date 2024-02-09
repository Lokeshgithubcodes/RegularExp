using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpProjects
{
    class Regex1
    {
        public void firstName()
        {
            Console.WriteLine("Enter the FirstName:");
            string fname=Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex r=new Regex(pattern);
            bool res=r.IsMatch(fname);
            if (res)
                Console.WriteLine("Valid FirstName");
            else
                Console.WriteLine("Not valid FirstName");
            Console.WriteLine();

        }
        public void lastName() 
        {
            Console.WriteLine("Enter the LastName:");
            string lname = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex r = new Regex(pattern);
            bool res = r.IsMatch(lname);
            if (res)
                Console.WriteLine("Valid LastName");
            else
                Console.WriteLine("Not valid LastName");
            Console.WriteLine();
        }
        public void email()
        {
            Console.WriteLine("Enter Email id");
            string email = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-z._%+-]{3,}$";
            Regex g1 = new Regex(pattern);
            bool result = g1.IsMatch(email);
            if (result)
            {
                Console.WriteLine("Email Valid");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }

        }



        public void ValidatePassword()
        {
            Console.WriteLine("Enter the Password:(ex:Password786@)");
            string password = Console.ReadLine();
            string patternpass = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            Regex r = new Regex(patternpass);
            bool res = r.IsMatch(password);
            if (res)
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("not a Valid password");
            Console.WriteLine();

        }

        public void phonenumber()
        {
            Console.WriteLine("Enter Phone number:(91 1234567890)");
            string s = Console.ReadLine();
            string pattern = @"^[0-9]{2} [0-9]{10}$";
            Regex reg = new Regex(pattern);
            bool result = reg.IsMatch(s);
            if (result)
            
                Console.WriteLine("Valid Phone number");
            
            else
            
                Console.WriteLine("Invalid Phone number");
            
        }
    


    static void Main(string[] args)
        {
            Regex1 k=new Regex1();
            //k.firstName();
            //k.lastName();
            //k.email();
           k.ValidatePassword();
            //k.phonenumber();
            
        }
    }
}
