using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class XmlProcessor
    {
        public string GetXmlData()
        {
            // XML verisi üreten bir metot
            return "<data><name>Ali Furkan Gokce</name><age>27</age></data>";
        }
    }
}
