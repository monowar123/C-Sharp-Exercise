using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTService
{
    public class WelcomeRESTService : IWelcomeRESTService
    {
        public string welcome(string name)
        {
            return string.Format("Welcome to WCF Web Service with REST and XML, {0}", name);
        }
    }
}
