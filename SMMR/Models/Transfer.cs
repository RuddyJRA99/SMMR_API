using System;
using System.Collections.Generic;

#nullable disable

namespace SMMR.Models
{
    public partial class Transfer
    {
        public long Id { get; set; }
        public long DebitAccountId { get; set; }
        public long CreditAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Concept { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Account CreditAccount { get; set; }
        public virtual Account DebitAccount { get; set; }
    }
}
