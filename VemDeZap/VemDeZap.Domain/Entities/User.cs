using prmToolkit.NotificationPattern;
using System;
using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Extensions;

namespace VemDeZap.Domain.Entities
{
    public class User : EntityBase
    {
        protected User()
        {

        }
        public User(string firstName,string email, string lastName, string password)
        {
            FirstName = firstName;
            Password = password;
            Email = email;
            LastName = lastName;

            new AddNotifications<User>(this)
                .IfNullOrInvalidLength(x => x.FirstName, 3, 150, "O Primeiro nome deve conter entre 3 a 150 caracteres")
                .IfNullOrInvalidLength(x => x.LastName, 3, 150)
                .IfNotEmail(x => x.Email)
                .IfNullOrInvalidLength(x => x.Password, 3, 32);

            if (!string.IsNullOrEmpty(this.Password))
            {
                this.Password = Password.ConvertToMD5();
            }

            DateRegister = DateTime.Now;
            Ativo = false;
                
        }

        public string FirstName { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string LastName { get; private set; }

        public DateTime DateRegister { get; private set; }

        public bool Ativo { get; private set; }
    }
}
