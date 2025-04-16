using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection.Emit;

namespace SmartInsuranceManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>()
            {
                new User(1, "Darko", "Pokoracki", "darkopokoracki@gmail.com", "ptkrf123#", "Employee"),
                new User(2, "John", "Doe", "johndoe@gmail.com", "ptkrf123#", "Client"),
                new User(3, "James", "Willson", "jameswillson@gmail.com", "jameswillson", "Employee"),
                new User(4, "Memphis", "Depay", "memphisdepay@gmail.com", "memphis", "Employee"),
                new User(5, "Wayne", "Rooney", "waynerooney@gmail.com", "rooney", "Client")
            };

            User loggedUser = null;
            
            Console.WriteLine("Welcome to Smart Insurance Application");

            Menu.ShowBasicMenu();

            int basicMenuOption = int.Parse(Console.ReadLine());

            if (basicMenuOption == 1)
            {
                Console.WriteLine("--Registration");
                Console.Write("Firstname: ");
                string firstname = Console.ReadLine();

                Console.Write("Lastname: ");
                string lastname = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("UserType, type client or employee: ");
                string userType = Console.ReadLine();

                int usersCount = users.Count();
                User user = new User(usersCount + 1, firstname, lastname, email, password, userType);
                users.Add(user);
            }

            if (basicMenuOption == 2)
            {
                Console.WriteLine("--Login");
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                loggedUser = users.Where(x => (x.email == email) && (x.password == password)).First();
            }
        }
    }
}
