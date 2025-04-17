using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    internal class Policy
    {
        private string _product;
        private string _coverage;
        private User _policyholder;
        private User _agent;

        public Policy(string product, string coverage, User policyholder, User agent)
        {
            this._product = product;
            this._coverage = coverage;
            this._policyholder = policyholder;
            this._agent = agent;
        }
    }
}
