//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace RegularExpProjects
//{
//    class RegularExps
//    {
//        public void validateUsername()
//        {
//            Console.WriteLine("Enter username:(ex: Lokesh123)");
//            string uname = Console.ReadLine();
//            string patternName = "^[A-Z]{1}[a-z]{4,}[0-9]{3}[@#$%&]{1}$";
//            Regex r = new Regex(patternName);
//            bool res = r.IsMatch(uname);
//            if (res)
//                Console.WriteLine("Valid Name");
//            else
//                Console.WriteLine("not a valid Name");
//            Console.WriteLine();

//        }
//        public void validatePhoneN0()
//        {
//            Console.WriteLine("Enter your phone number:(ex:+91123-456-7890)");
//            string phoneNo = Console.ReadLine();
//            string patternNo = "^[+0-9]{3}[0-9]{3}-[0-9]{3}-[0-9]{4}$";
//            Regex r = new Regex(patternNo);
//            bool res = r.IsMatch(phoneNo);
//            if (res)
//                Console.WriteLine("Valid Number");
//            else
//                Console.WriteLine("not a Valid number");
//            Console.WriteLine();

//        }

//        public void ValidatePassword()
//        {
//            Console.WriteLine("Enter the Password:(ex:Password786@)");
//            string password = Console.ReadLine();
//            string patternpass = "^[A-Z]{1,}[a-z]{4,}[0-9]{3,}[!@#$%&*]{1}$";
//            Regex r = new Regex(patternpass);
//            bool res = r.IsMatch(password);
//            if (res)
//                Console.WriteLine("Password is Valid");
//            else
//                Console.WriteLine("not a Valid password");
//            Console.WriteLine();

//        }

//        public void email()
//        {
//            Console.WriteLine("Enter Email id");
//            string email = Console.ReadLine();
//            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-z]{3,}$";
//            Regex g1 = new Regex(pattern);
//            bool result = g1.IsMatch(email);
//            if (result)
//            {
//                Console.WriteLine("Email Valid");
//            }
//            else
//            {
//                Console.WriteLine("Invalid Email");
//            }

//        }
//        static void Main()
//        {

//            RegularExps c = new RegularExps();

//            --code for validate the username
//            c.validateUsername();

//            ---code for valid the phone number
//            c.validatePhoneN0();

//            -----code for password
//            c.ValidatePassword();

//            -----code for Email
//            c.email();


//        }

//    }
//}
