// SE145 / Lab4 / Part 2 / Walid AMAR / Week 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE245_LAB4_wamar_Part2
{
    class Program
    {
        struct Person
        {
            public string FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email;
        }

        // Pause function
        static void Pause()     
        {
            Console.WriteLine(" Press any key to exit. ");
            Console.ReadKey();
        }
        //Main Loop
        static void Main(string[] args)
        {

            Person temp = new Person();

            // User's input
            Console.Write("     Hello !");
            Console.Write("\n \n     Please enter the following informations :");
            Console.Write("\n \n First Name : ");
            temp.FName = Console.ReadLine() + " Poopy";
            Console.Write(" Middle Name : ");
            temp.MName = Console.ReadLine();
            Console.Write(" Last Name : ");
            temp.LName = Console.ReadLine();
            Console.Write(" Street 1 : ");
            temp.Street1 = Console.ReadLine();
            Console.Write(" Street 2 : ");
            temp.Street2 = Console.ReadLine();
            Console.Write(" City : ");
            temp.City = Console.ReadLine();
            Console.Write(" State : ");
            temp.State = Console.ReadLine();
            Console.Write(" Zip : ");
            temp.Zip = Console.ReadLine();
            Console.Write(" Phone Number : ");
            temp.Phone = Console.ReadLine();
            Console.Write(" Email : ");
            temp.Email = Console.ReadLine();

            //Output
            Console.WriteLine("\n \n Here is your person's information : ");
            Console.WriteLine(" First Name : " + temp.FName);
            Console.WriteLine(" Middle Name : " + temp.MName);
            Console.WriteLine(" Last Name : " + temp.LName);
            Console.WriteLine(" Street 1 : " + temp.Street1);
            Console.WriteLine(" Street 2 : " + temp.Street2);
            Console.WriteLine(" City : " + temp.City);
            Console.WriteLine(" State : " + temp.State);
            Console.WriteLine(" Zip : " + temp.Zip);
            Console.WriteLine(" Phone : " + temp.Phone);
            Console.WriteLine(" Email : " + temp.Email);
            Pause();
        }
    }
}