using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTFUL_Webservices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{num1}/{num2}")]
        public string add(string num1, string num2)
        {
            double a = Convert.ToDouble(num1);
            double b = Convert.ToDouble(num2);
            return Convert.ToString(a + b);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "multiply/{num1}/{num2}")]
         public string multiply(string num1, string num2)
        {
            double a = Convert.ToDouble(num1);
            double b = Convert.ToDouble(num2);
            return Convert.ToString(a * b);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub/{num1}/{num2}")]
         public string sub(string num1, string num2)
        {
            double a = Convert.ToDouble(num1);
            double b = Convert.ToDouble(num2);
            return Convert.ToString(a - b);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div/{num1}/{num2}")]
        public string div(string num1, string num2)
        {
            double a = Convert.ToDouble(num1);
            double b = Convert.ToDouble(num2);
            return Convert.ToString(a / b);
        }
    }
}
