using LexiconExercise_3.Errors;
using LexiconExercise_3.Handlers;
using LexiconExercise_3.Helpers;
using LexiconExercise_3.Models;
using System.Diagnostics;

namespace LexiconExercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleHandler handler = new VehicleHandler();
            Utils utils = new Utils();

            string input = string.Empty;
            do
            {
                IndexHelper.ShowMenu();
                input = Console.ReadLine();
                IndexHelper.InputHandler(input, handler, utils);
            }
            while (input != IndexHelper.QUIT);
        }

        //Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
        //Det borde bli ett kompileringsfel då Car och Motorcycle är olika klasser och delar inte samma typ.

        //Vilken typ bör en lista vara för att rymma alla fordonstyper?
        //List<Vehicle> då den innefattar alla fordon. Car, Motorcycle etc ärver ifrån

        //Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
        //Ja med hjälp av såkallad typkontroll "is" eller "as".

        //Vad är fördelarna med att använda ett interface här istället för arv?
        //Mer flexibilitet och bättre delning än arv. Klasserna kan implementera interfaces utan att vara beroende av hierarkin i arv.
    }
}