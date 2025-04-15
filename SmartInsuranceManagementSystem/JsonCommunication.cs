using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    internal class JsonCommunication
    {
        public static object FetchAllUsers(string filePath)
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

            string allUsersJsonContent = File.ReadAllText(userFilePath);

            var userConvertedData = JsonConvert.DeserializeObject<object>(allUsersJsonContent);

            return userConvertedData;
        }


    }
}
