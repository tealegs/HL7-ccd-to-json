using System;
using System.Xml;
using Newtonsoft.Json;
//using System.IO;

//using JsonConvert;
// using XmlDocument;

namespace ccd_parsing

{
    class Program
    {
        static void Main(string[] args)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("ccd-sample.xml");
            string xmlcontents = doc.InnerXml;
            string json = JsonConvert.SerializeXmlNode(doc);

            Console.WriteLine("writing json");
            System.IO.File.WriteAllText("ccd-sample.json", json);
            Console.WriteLine("json write complete.");
        }
    }
}
