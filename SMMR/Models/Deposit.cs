using System;
using System.Collections.Generic;

#nullable disable

namespace SMMR.Models
{
    public partial class Deposit
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Concept { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Account Account { get; set; }
    }
}
