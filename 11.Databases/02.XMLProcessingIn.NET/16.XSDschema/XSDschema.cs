namespace _16.XSDschema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class XSDschema
    {
        static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, "../../catalogue.xsd");
            
            XDocument catalogue = XDocument.Load("../../catalogue.xml");
            bool valid = true;
            catalogue.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                valid = false;
            });
            Console.WriteLine("catalogue validate: {0}", valid);
            

            XDocument catalogueInvalid = XDocument.Load("../../catalogueInvalid.xml");
            valid = true;
            catalogueInvalid.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                valid = false;
            });
            Console.WriteLine("catalogue validate: {0}", valid);
        }
    }
}
