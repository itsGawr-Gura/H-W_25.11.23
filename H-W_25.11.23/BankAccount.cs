using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    // EX 13.1-13.2, EX 14.1
    [DeveloperInfo("Andrew Antonov","05.12.2023","KFU")]
    public class BankAccount
    {

        public int AccountNumber { get; }
        public string AccountType { get; }
        public string Holder { get; set; }

        private List<BankTransaction> _transactions = new List<BankTransaction>();
      
        public BankAccount(int accountNumber, string accountType)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
        }

        public BankTransaction this[int index]
        {
            get { return _transactions[index]; }
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Тип счета: {AccountType}");
            Console.WriteLine($"Владелец: {Holder}");

            Console.WriteLine("Транзакции:");
            foreach (var transaction in _transactions)
            {
                Console.WriteLine($"{transaction.Date}: {transaction.Amount} - {transaction.Description}");
            }
        }

    }
}
