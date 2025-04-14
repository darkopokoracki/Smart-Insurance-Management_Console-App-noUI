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

                User user = new User(User.GetNextId(), firstname, lastname, email, password, userType);
                user.Register();
            }

            if (basicMenuOption == 2)
            {
                Console.WriteLine("--Login");
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                // Fetch User data from JsonCommunication and make object and login that user.
            }


            // Implement class Workflow which will be parent class.
            // We will have more workflows to structure code.
            // PolicyWorkFlow, UserWorkFlow, Login Workflow... (Create simple solution for this.)


            /*
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

            if (File.Exists(userFilePath))
            {
                string allUsersJsonContent = File.ReadAllText(userFilePath);

                var userConvertedData = JsonConvert.DeserializeObject<UsersWrapper>(allUsersJsonContent);

                foreach(var user in userConvertedData.Users)
                {
                    Console.WriteLine(user.firstname);
                }

            }
            */
        }
    }
}
