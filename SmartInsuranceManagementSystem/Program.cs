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
                Console.WriteLine("Registration: ");
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Password: ");
                string password = Console.ReadLine();
            }


            // Implement class Workflow which will be parent class.
            // We will have more workflows to structure code.
            // PolicyWorkFlow, UserWorkFlow, Login Workflow... (Create simple solution for this.)



            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

            Console.WriteLine($"User file path is: {userFilePath}");

            if (File.Exists(userFilePath))
            {
                string allUsersJsonContent = File.ReadAllText(userFilePath);

                var userConvertedData = JsonConvert.DeserializeObject<UsersWrapper>(allUsersJsonContent);

                foreach(var user in userConvertedData.Users)
                {
                    Console.WriteLine(user.Firstname);
                }

            } else
            {
                Console.WriteLine("Users.json does't exists");
            }
        }
    }
}
