using System.Transactions;

namespace QueteLesConstructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            string toContinue;
            int nombresDEtages = 0;
            int hauter = 0;
            Building building1; //Building(nombre de étages , hauter )
            Building building2; //Building(nombre de étages)

            while (true)
            {

                Console.WriteLine("Please choose one from the below according to the details you have and enter associated choice number : ");
                Console.WriteLine("1. You have number of floors and size of the building");
                Console.WriteLine("2. You have number of floors of the building.");
                int.TryParse(Console.ReadLine(), out userChoice);

                if (userChoice == 1)
                {
                    Console.WriteLine("Please enter the number of floors : ");
                    int.TryParse(Console.ReadLine(), out nombresDEtages);
                    Console.WriteLine("Please enter the size of the building : ");
                    int.TryParse(Console.ReadLine(), out hauter);

                    building1 = new Building(nombresDEtages, hauter);
                    building1.Display();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Please enter the number of floors : ");
                    int.TryParse(Console.ReadLine(), out nombresDEtages);

                    building2 = new Building(nombresDEtages);
                    building2.Display();
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice.");
                }

                Console.WriteLine("Do you want to continue? y/n");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
        }
    }
}
