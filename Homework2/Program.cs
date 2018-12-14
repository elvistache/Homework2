using System;

namespace Homework2
{


    public enum Gender
    {
        male,
        female
    }
    class Program
    {


        static void Main(string[] args)
        {
        BirthdateDefinition:
            Console.WriteLine("Enter your birthdate in the mm-dd-yyyy  format:");
            string date = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(date);

            

        //TimeSpan age = DateTime.Now.Subtract(birthdate);

        //double yo = age.Days / 365;
        //Console.WriteLine("You are {0} years old.", yo);

        GenderDefinition:
            Console.WriteLine("Are you male or Female? (M/F)");
            string gender = Console.ReadLine();

            Gender person = new Gender();

            if (gender == "M")
            {
                person = Gender.male;
                Console.WriteLine("you are a male");
            }
            else if (gender == "F")
            {
                person = Gender.female;
            }
            else
            {
                Console.WriteLine("invalid gender");
                goto GenderDefinition;
            }
            
            int numericValue = (int)person;
            if (person == Gender.male)
            {
                Console.WriteLine("you rest at 65");
            }

            if (person == Gender.female)
            {
                Console.WriteLine("you rest at 63");
            }
           
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
