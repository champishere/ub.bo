using System;

namespace ub.bo
{
    public class Account
    {
        public int CustomerNumber { get; set; }

        public string AccountName { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string AccountAlias { get; set; }

        public string AccountNumber { get; set; }

        public int BankNumber { get; set; }

        public int BranchNumber { get; set; }

        public int AccNo { get; set; }

        public int Suffix { get; set; }

        public string Date { get; set; }

        public virtual double AccountBalance { get; set; }

        public string AccountStatus { get; set; }

        public string AccountType { get; set; }

    }
}
