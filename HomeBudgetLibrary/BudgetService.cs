using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HomeBudgetData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeBudgetLibrary
{
    public class BudgetService
    {
        string _connectionString;

        public BudgetService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            _connectionString = configuration.GetConnectionString("Default");
        }

        public List<User> GetUsers()
        {
            List<User> result = null;
            using (var db = new BudgetContext(_connectionString))
            {
                result = db.Users.ToList();
            }

            return result;
        }

        public List<Transaction> GetTransactions()
        {
            List<Transaction> result = null;
            using (var db = new BudgetContext(_connectionString))
            {
                result = db.Transactions.ToList();
            }

            return result;
        }

        public bool AddTranscation(Transaction newTransaction)
        {
            bool result;

            try
            {
                using (var db = new BudgetContext(_connectionString))
                {
                    db.Transactions.Add(newTransaction);
                    int count = db.SaveChanges();
                    result = count > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        //public static List<Tuple<User,decimal>> GetCurrentBalance()
        //{
        //    decimal result;

        //    try
        //    {
        //        using (var db = new BudgetContext())
        //        {
        //            //List<User> users = db.Users.Include(u => u.Transactions).ToList();

        //            //users.Select(u => new
        //            //     {
        //            //         user = u,
        //            //         totalAmountSpent = u.Transactions.Sum(t => t.AmountSpent),
        //            //     })
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return result;
        //}
    }
}
