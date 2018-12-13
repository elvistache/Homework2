using System;

namespace Homework2
{
    
    
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate in the dd-mm-yyyy  format:");
            string date = Console.ReadLine();

            Console.WriteLine("Are you male or Female? (M/F)");
            string gender = Console.ReadLine();

            DateTime birthdate = DateTime.Parse(date);
            TimeSpan age = DateTime.Now.Subtract(birthdate);

            double yo = age.Days / 365;
            Console.WriteLine("You are {0} years old.", yo);


            Console.ReadLine();
            Environment.Exit(0);
        } 
    }
}
