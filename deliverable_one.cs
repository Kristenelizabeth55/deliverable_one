using System;

namespace deliverable_one
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool reRun = true;
            while (reRun)
            {

                Console.WriteLine("How many people are we making PB and J sandwiches for?");
                string userInput = Console.ReadLine();
                int userInputNumber = Int32.Parse(userInput);

                int slices = 2;
                int tablespoons = 2;
                int teaspoons = 4;

                Console.WriteLine("You need:");
                Console.WriteLine();
                Console.WriteLine((slices * userInputNumber) + " slices of bread \n" + (tablespoons * userInputNumber) + " tablespoons of peanut butter \n" + (teaspoons * userInputNumber) + " teaspoons of jelly");
                Console.WriteLine();

                decimal totalLoaves = 28;
                decimal totalSlicesNeeded = (slices * userInputNumber);
                decimal totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / totalLoaves);

                decimal jarOfPeanutButter = 32;
                decimal totalTablespoonsOfPeanutButterNeeded = (tablespoons * userInputNumber);
                decimal totalJarsOfPeanutButterNeeded = Math.Ceiling(totalTablespoonsOfPeanutButterNeeded / jarOfPeanutButter);

                decimal jarOfJelly = 48;
                decimal totalTeaspoonsOfJellyNeeded = (teaspoons * userInputNumber);
                decimal totalJarsOfJellyNeeded = Math.Ceiling(totalTeaspoonsOfJellyNeeded / jarOfJelly);

                Console.WriteLine("which is: \n");
                Console.WriteLine(totalLoavesNeeded + " loaves of bread \n" + totalJarsOfPeanutButterNeeded + " jars of peanut butter \n" + totalJarsOfJellyNeeded + " jars of jelly \n");

                Console.WriteLine("Would you like to start the program over?");
                string reRunProgram = Console.ReadLine();

                if (reRunProgram == "y" || reRunProgram == "yes")
                {
                    reRun = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
