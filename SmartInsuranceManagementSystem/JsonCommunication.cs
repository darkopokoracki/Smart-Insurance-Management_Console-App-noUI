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
        string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");
    }
}
