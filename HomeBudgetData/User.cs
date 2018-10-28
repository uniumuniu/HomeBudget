using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetData
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
