using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RESTService
{
    [ServiceContract]    
    public interface IWelcomeRESTService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/welcome/{name}")]
        string welcome(string name);    
    }

}
