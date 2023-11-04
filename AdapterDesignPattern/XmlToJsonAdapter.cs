using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern
{
    public class XmlToJsonAdapter : JsonData
    {
        private XmlProcessor xmlProcessor;

        public XmlToJsonAdapter(XmlProcessor xmlProcessor)
        {
            this.xmlProcessor = xmlProcessor;
        }

        public void ParseXmlData()
        {
            string xmlData = xmlProcessor.GetXmlData();


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);

            JsonObject jsonData = new JsonObject();

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {

                if (node.Name == "name")
                {
                    jsonData["Name"] = node.InnerText;
                }
                else if (node.Name == "age")
                {
                    if (int.TryParse(node.InnerText, out int age))
                    {
                        jsonData["Age"] = age;
                    }
                }
            }


            this.Name = jsonData["Name"].ToString();
            this.Age = (int)jsonData["Age"];
        }
    }
}
