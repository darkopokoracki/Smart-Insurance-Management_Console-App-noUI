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

        public User(int id, string firstname, string lastname, string email, string password, string userType)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.userType = userType;
        }
        public override string ToString()
        {
            return $"User {firstname} {lastname} with type {userType} and with Id {id}";
        }
    }
}
