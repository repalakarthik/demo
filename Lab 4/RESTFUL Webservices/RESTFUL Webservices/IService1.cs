using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTFUL_Webservices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string add(string num1, string num2);

        [OperationContract]
        string multiply(string num1, string num2);

        [OperationContract]
        string sub(string num1, string num2);

        [OperationContract]
        string div(string num1, string num2);


        // TODO: Add your service operations here
    }


    
}
