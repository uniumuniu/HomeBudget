using System;
using HomeBudgetLibrary;

namespace HomeBudgetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = BudgetService.GetUsers();

            foreach(var user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
