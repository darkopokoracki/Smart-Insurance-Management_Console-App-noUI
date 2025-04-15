using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    internal class User
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string lastname { get; set; }
        public string userType { get; set; }

        public static List<User> users = new List<User>()
        {
            new User(1, "Darko", "Pokoracki", "darkopokoracki@gmail.com", "ptkrf123#", "Emplyee"),
            new User(2, "Nikola", "Hromcik", "nikolahromcik@gmail.com", "ptkrf123#", "Client"),
            new User(3, "Desanka", "Maksimovic", "desankamaksimovic@gmail.com", "ptkrf123#", "Employee")
        };

        private User loggedUser = null;

        
        public User(int id, string firstname, string lastname, string email, string password, string userType)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.userType = userType;
        }

        public static void RegisterForm()
        {
            Console.WriteLine("Registration: ");
            Console.WriteLine("Firstname: ");
            Console.WriteLine("Lastname: ");
            Console.WriteLine("Email: ");
            Console.WriteLine("Password: ");
        }

        public static int GetNextId()
        {
            return 1;
        }

        public void Register()
        {
            this.loggedUser = this.users[0];
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Current user {firstname} {lastname} logged as {userType} with Id {id}";
        }
    }
}
