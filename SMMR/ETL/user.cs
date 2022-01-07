using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMMR.ETL
{
    public class userRegister : Entity<userRegister>
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string second_surname { get; set; }
        [Required]
        public string mail { get; set; }
        public string phone { get; set; }
        [Required]
        public string password { get; set; }
    }

    public class userLogin : Entity<userLogin>
    {
        [Required]
        public string mail { get; set; }
        [Required]
        public string password { get; set; }
    }
}
