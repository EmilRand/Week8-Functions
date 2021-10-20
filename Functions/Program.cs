using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi!");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi!");
            string userSurname = Console.ReadLine();
            Console.WriteLine("Sisesta oma sünniaasta!");
            int userAge = Convert.ToInt32(Console.ReadLine()); 
            greetings(userName, userAge, userSurname);
        }

        private static void greetings(string someString, int someInt, string anotherString)
        {
            Console.WriteLine($"tere! {someString} {anotherString} ");
            Console.WriteLine($"Oled {2021 -someInt}.");
        }
        
            
        
    }
}
