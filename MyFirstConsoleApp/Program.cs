using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ZahlenRatenSpiel();
            Method1Einfuehrung();
            Method2ArraysUndSchleifen();
           

        }

        private static void ZahlenRatenSpiel()
        {
            const int maxVersuche = 10;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);

            int inputNumber;

            bool erratenJaNein = false;

            string ausgabeText;

            int counter = 0;

            do
            {
                Console.WriteLine($"Bitte geben sie Ihren {counter+1} Tipp ab");

                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == randomNumber)
                {
                    erratenJaNein = true;
                }
                else
                {
                    counter++;
                    if (inputNumber<randomNumber)
                    {
                        ausgabeText = "Die Zahl ist höher";
                    }
                    else
                    {
                        ausgabeText = "Die Zahl ist niedriger";
                    }
                    Console.WriteLine(ausgabeText);
                }
              

            } while (counter<=10 && erratenJaNein==false);

            if (erratenJaNein==true)
            {
                ausgabeText = $"Super Sie haben die Zahl mit {counter} Versuchen erraten";
            }
            else
            {
                ausgabeText = $"Die Zahl war {randomNumber} und wurde nicht erraten";
            }


        }

        private static void Method2ArraysUndSchleifen()
        {
            int[] zahlen = new int[4];
            zahlen[0] = 1;
            zahlen[2] = 7;

            string[] produkte = { "Handy", "Taschenlampe", "Maus" };

            if (produkte[0] == "Handy" || produkte[0].Equals("Handy"))
            {
                Console.WriteLine("Ja ein Handy");
            }

            switch (produkte[0])
            {
                case "Handy":
                    Console.WriteLine("war ein Handy");
                    break;
                case "Maus":
                    Console.WriteLine("war Maus");
                    break;
                default:
                    break;
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine($"Die Zahl {i+1} hat den Wert {zahlen[i]}");
            }

            foreach (var zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }

            int z1 = 12;
            var z2 = 14;

            int z3;
            // var z4;

            //Zahlenrate spiel- neue Methode "ZahlenRaten"
            //Computer überlegt sich eine zufällige Zahl (0 bis 100) Random
            //max. 10 Mal die Möglichkeit einen Tipp abzugeben
            //Beispiel zufällige Zahl ist 37
            //1. Tipp --> 50
            //Ihre Eingabe ist höher als die zufällige Zahl
            //Oje - Sie haben die Zahl nicht erraten
            //Super - Sie haben die Zahl nach 3 Versuchen erraten
            //for -- 0 .. 9 ... break;
            //do while(ZahlNichtErraten und Versuche kleiner 10) --

            Random rnd = new Random();
            int rndNumber = rnd.Next(0, 100);




        }

        private static void Method1Einfuehrung()
        {
            //lokale Variablen deklarien
            string firstName; //string ist Alias für System.String
            int plz = 0; //int ist ein alias für System.Int32

            double plzDbl = 0;

            plzDbl = plz; //implizite Konvertierung

            plzDbl = double.MaxValue;

            checked
            {
                try
                {
                    plz = (int)plzDbl;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ein Fehler{ex.Message}");
                    throw;
                }

            }


            System.String lastName = "Grabner";
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
