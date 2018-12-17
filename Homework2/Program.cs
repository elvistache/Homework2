using System;

namespace Homework2
{


    public enum Gender
    {
        Male = 0,
        Female = 0  
    }
    class Program
    {


        static void Main(string[] args)
        {

        BirthdateDefinition:
            Console.WriteLine("Enter your birthdate in the mm-dd-yyyy  format:");
            string date = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(date);

        AgeCalculator:
            TimeSpan age = DateTime.Now.Subtract(birthdate);

            int yo = age.Days / 365;
            Console.WriteLine("You are {0} years old.", yo);

        GenderDefinition:
            Console.WriteLine("Are you male or Female? (M/F)");
            string @char = Console.ReadLine();
            if (@char == "m")
            {
                Gender gender = Gender.Male;
                TimeSpan time = DateTime.Now.AddYears(65 - yo) - DateTime.Now;
                if (time.TotalDays / 365 < 0)
                {
                    Console.WriteLine("The person is retired");
                }
                else
                {
                    Console.WriteLine("The person will be retired in {0} years.", time.TotalDays / 365);
                }
            }
            else if (@char == "f")
            {
                Gender gender = Gender.Female;
                TimeSpan time = DateTime.Now.AddYears(63 - yo) - DateTime.Now;
                if (time.TotalDays / 363 < 0)
                {
                    Console.WriteLine("The person is retired");
                }
                else
                {
                    Console.WriteLine("The person will be retired in {0} years.", time.TotalDays / 365);
                }
            }
            else
            {
                Console.WriteLine("invalid gender. please enter it again");
                goto GenderDefinition;
            }
            
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
