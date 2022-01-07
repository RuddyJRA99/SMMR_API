using System;
using System.Collections.Generic;

#nullable disable

namespace SMMR.Models
{
    public partial class Account
    {
        public Account()
        {
            Deposits = new HashSet<Deposit>();
            TransferCreditAccounts = new HashSet<Transfer>();
            TransferDebitAccounts = new HashSet<Transfer>();
        }

        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<Transfer> TransferCreditAccounts { get; set; }
        public virtual ICollection<Transfer> TransferDebitAccounts { get; set; }
    }
}
