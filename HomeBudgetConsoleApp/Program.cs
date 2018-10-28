using System;
using System.Collections.Generic;
using HomeBudgetData;
using HomeBudgetLibrary;

namespace HomeBudgetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type:");
            Console.WriteLine("su - to show users");
            Console.WriteLine("st - to show transactions");
            //Console.WriteLine("a - to add transaction");
            //Console.WriteLine("sb - to show balance");
            Console.WriteLine();

            string command = Console.ReadLine();

            if (command == "su")
            {
                ShowUsers();
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static BudgetService BudgetService { get; } = new BudgetService();

        static void ShowUsers()
        {
            List<User> users = BudgetService.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        static void ShowTransactions()
        {
            List<Transaction> transactions = BudgetService.GetTransactions();

            foreach (var transaction in transactions)
            {
                //Console.WriteLine();
            }
        }

        static void AddTransaction()
        {

        }

        static void ShowBalance()
        {

        }
    }
}
