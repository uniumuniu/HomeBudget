using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeBudgetData
{
    public class BudgetContext : DbContext
    {
        string _connectionString;

        public BudgetContext() { }

        public BudgetContext(string connectionString)
        {
            if (_connectionString == null || _connectionString == string.Empty)
            {
                _connectionString = connectionString;
            }
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
