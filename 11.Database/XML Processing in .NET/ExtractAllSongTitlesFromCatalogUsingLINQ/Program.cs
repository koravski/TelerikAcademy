namespace ExtractAllSongTitlesFromCatalogUsingLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../Catalogue.xml");

            var albumNames = from album in doc.Descendants("songs")
                             select album.Element("title").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumNames));
        }
    }
}