using SMMR.ETL;
using System;
using System.Collections.Generic;

#nullable disable

namespace SMMR.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Role { get; set; }
        public bool? MailConfirm { get; set; }
        public bool? IdentityConfirm { get; set; }
        public string AuthCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }

    public class UserModel : Model<User>
    {
       

        public string login(userLogin model)
        {
            //busqueda del usuario
            User usr = getOneByCondition(x => x.Mail == model.mail && x.Password == model.password);
            
            //validacion del usuario
            if (usr == null) throw new ArgumentNullException("wrong mail or password");

            //generar y retornar token

            return "token";
        }
        public bool register(userRegister model)
        {
            return this.store(new User {
                Name = model.name,
                Surname = model.surname,
                SecondSurname = model.second_surname,
                Mail = model.mail,
                Phone = model.phone,
                Password = model.password
            });
        }

    }

}
