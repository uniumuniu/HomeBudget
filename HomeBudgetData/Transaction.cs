using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeBudgetData
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public decimal AmountSpent { get; set; }

        public TransactionType Type { get; set; }

        public string Info { get; set; }
    }
}
