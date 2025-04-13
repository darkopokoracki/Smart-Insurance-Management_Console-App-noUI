using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    internal class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Lastname { get; set; }
        public string UserType { get; set; }

        
        public User(int id, string firstname, string lastname, string email, string password, string userType)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Password = password;
            this.UserType = userType;
        }

        public static void RegisterForm()
        {
            Console.WriteLine("Registration: ");
            Console.WriteLine("Firstname: ");
            Console.WriteLine("Lastname: ");
            Console.WriteLine("Email: ");
            Console.WriteLine("Password: ");
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Current user {Firstname} {Lastname} logged as {UserType} with Id {Id}";
        }
    }
}
