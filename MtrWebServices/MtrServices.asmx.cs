using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace MtrWebServices
{
    /// <summary>
    /// Summary description for MtrServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MtrServices : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n < 1)
                return -1;

            if (n > 100)
                return -1;

            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                return jsonText;
            }
            catch (XmlException ex)
            {
                return ex.GetBaseException().Message;
            }
        }
    }
}
