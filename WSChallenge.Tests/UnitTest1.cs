using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using Newtonsoft.Json;

namespace WSChallenge.Tests
{

    
    [TestClass]
    public class UnitTest1
    {
        //Fibonnaci test method
        [TestMethod]
        public void Fibonnaci_With_Number_1()
        {
            long result = WebService.Fibonnaci(6);
            Assert.AreEqual(8,result);
        }

        [TestMethod]
        public void Fibonnaci_With_Number_Negative_Value()
        {
            long result = WebService.Fibonnaci(-101);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Fibonnaci_With_Number_1000()
        {
            long result = WebService.Fibonnaci(1000);
            Assert.AreEqual(-1, result);
        }


        //XmltoJson test method
        [TestMethod]
        public void XmltoJson_With_bad_string()
        {
            string parameter = "<foo>hello</bar>";
            string result = WebService.XmlToJson(parameter);
            Assert.AreEqual("Bad Xml format", result);
        }

        [TestMethod]
        public void XmltoJson_With_good_string()
        {
            string parameter = "<foo>bar</foo>";
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(parameter);
            string json = JsonConvert.SerializeXmlNode(xml);
            string result = WebService.XmlToJson(parameter);
            Assert.AreEqual(json, result);
        }
    }
}
