namespace XSLTransformation
{
    using System.Xml.Xsl;

    internal class Program
    {
        private static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../Catalogue.xsl");
            xslt.Transform("../../catalogue.xml", "../../catalogue.html");
        }
    }
}