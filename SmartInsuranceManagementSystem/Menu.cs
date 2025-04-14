using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    static class Menu
    {
        public static void ShowBasicMenu()
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.Write("Enter possible option: ");
        }

        public static void ShowMenuForClient()
        {
            Console.WriteLine("1. Request Policy");
            Console.WriteLine("2. Request Claim");
            Console.WriteLine("3. Pay Policy");
            Console.WriteLine("4. My Policies");
        }

        public static void ShowMenuForEmployee()
        {
            Console.WriteLine("1. Requests from the client");
        }
    }
}
