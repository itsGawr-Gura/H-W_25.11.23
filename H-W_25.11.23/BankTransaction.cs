using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    public class BankTransaction
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public string Description { get; }

        public BankTransaction(DateTime date, decimal amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }
    }
}
