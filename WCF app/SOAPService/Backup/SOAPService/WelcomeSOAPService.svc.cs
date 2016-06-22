using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    public class WelcomeSOAPService : IWelcomeSOAPService
    {
        public string Welcome(string name)
        {
            return string.Format("Welcome to WCF Web Services with SOAP and XML, {0}", name);
        }
    }
}
