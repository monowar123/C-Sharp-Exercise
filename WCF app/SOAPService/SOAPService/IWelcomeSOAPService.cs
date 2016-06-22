﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    [ServiceContract]
    public interface IWelcomeSOAPService
    {
        [OperationContract]        
        string Welcome(string name);
    }
}
