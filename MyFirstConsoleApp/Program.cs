using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //lokale Variablen deklarien
            string firstName; //string ist Alias für System.String
            int plz; //int ist ein alias für System.Int32

            System.String lastName="Grabner";
            System.Int32 streetNumber;


            Console.WriteLine("Hello World!");

            Console.WriteLine("Wie heißen Sie?");

            firstName = Console.ReadLine();

            Console.WriteLine("Wo wohnen Sie? (PLZ)");

            plz = int.Parse(Console.ReadLine());

            Console.WriteLine("Hallo und herzlich Willkommen " + firstName);
            Console.WriteLine("Hallo {0} {1} herzlich Willkommen ", firstName, lastName);
            Console.WriteLine($"Hallo {firstName} {lastName} herzlich Willkommen {plz}"); //



        }
    }
}
