using AdapterDesignPattern;

XmlProcessor xmlProcessor = new XmlProcessor();
XmlToJsonAdapter adapter = new XmlToJsonAdapter(xmlProcessor);

// XML verisini JSON'a dönüştür
adapter.ParseXmlData();

// JSON verisini kullan
Console.WriteLine("Name: " + adapter.Name);
Console.WriteLine("Age: " + adapter.Age);