namespace _07.CreateXMLdocument
{
    using System;
    using System.Xml.Linq;

    class CreateXMLdocument
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines("../../../personData.txt");
            XElement people = new XElement("people");

            for (int i = 0; i < lines.Length; i+=3)
            {
                XElement person = new XElement("person",
                                new XElement("name", lines[i]),
                                new XElement("address", lines[i + 1]),
                                new XElement("phone", lines[i + 2])
                            
                            );
                people.Add(person);
            }

            Console.WriteLine(people);

            people.Save("../../../people.xml");
        }
    }
}
