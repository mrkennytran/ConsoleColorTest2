using System;

namespace consoleColorEx092021
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kenny Tran";
            string address = "228 Hello World Blvd \nBiloxi, MS 39530";
            string phone = "228-123-4567";


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(name);
            Console.WriteLine(address);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(phone);


        }
    }
}
