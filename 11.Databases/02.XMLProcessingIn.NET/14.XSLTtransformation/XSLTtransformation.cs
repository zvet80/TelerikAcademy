namespace _14.XSLTtransformation
{
    using System.Xml.Xsl;

    class XSLTtransformation
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../../catalogStyle.xsl");
            xslt.Transform("../../../catalogue.xml", "../../../catalogue.html");
        }
    }
}
