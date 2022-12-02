using System;
namespace stringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Thai Thanh Nguyen";
            //fullname = fullname.ToUpper();
            //fullname = fullname.ToLower();
            //System.Console.WriteLine(fullname);

            //String phonenumber = "123-456-789";
            //phonenumber = phonenumber.Replace("-", "/");
            //System.Console.WriteLine(phonenumber);
            
            
            //String username = fullname.Insert(0,"MR.");
            //System.Console.WriteLine(username);
            
            
            //System.Console.WriteLine(fullname.Length);
            
            String firstname = fullname.Substring(0, 4);
            String lastname = fullname.Substring(5,12);
            System.Console.WriteLine(firstname);
            System.Console.WriteLine(lastname);
            
            
            Console.ReadKey();
        }
    }
}