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

            /*
            List<string> korisnici = new List<string>();
            korisnici.Add("Darko");
            korisnici.Add("Nikola");
            korisnici.Add("Vierka");

            foreach(var korisnik in korisnici)
            {
                Console.WriteLine(korisnik);
            }
            */

            foreach(var u in User.users)
            {
                Console.WriteLine(u);
            }


            /*
            List<Korisnik> korisnici = new List<Korisnik>();
            Korisnik k1 = new Korisnik("Darko", "Pokoracki", "darkopokoracki@gmail.com", "ptkrf123#", "Zaposleni");
            Korisnik k2 = new Korisnik("Vierka", "Pokoracki", "vierkapokoracki@gmail.com", "ptkrf123#", "Zaposleni");

            korisnici.Add(k1);
            korisnici.Add(k2);

            foreach(Korisnik korisnik in korisnici)
            {
                Console.WriteLine(korisnik);
            }
            */


            /*
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

                var users = JsonCommunication.FetchAllUsers("users.json");
                Console.WriteLine(users);
               

                // Fetch User data from JsonCommunication and make object and login that user.

            }
            */

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
