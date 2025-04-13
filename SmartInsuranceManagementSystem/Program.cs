using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            }
        }
    }
}
