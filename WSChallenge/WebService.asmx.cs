using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Services;
using System.Xml;

namespace WSChallenge
{
    /// <summary>
    /// Description résumée de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService : System.Web.Services.WebService
    {
        //Fibonnaci method
        [WebMethod]
        public static long Fibonnaci(int n)
        {
            try
            {
                long n1 = 1;
                long n2 = 1;

                if (n > 0 && n<1000)
                {
                    if (n <= 2) return 1;
                    else
                    {
                        for (int i = 3; i < n; i++)
                        {
                            if ((i & 1) == 0) n1 += n2;
                            else n2 += n1;
                        }
                        return n1 + n2;
                    }
                }
                return -1;
            }
            catch(Exception e)
            {
                return 0;
            }
        }


        //XmlToJson method
        [WebMethod]
        public static string XmlToJson (string s)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(s);

                string json = JsonConvert.SerializeXmlNode(xml);
                return json;
            }
            catch(Exception e)
            {
                return "Bad Xml format";
            }
        } 
    }
}
