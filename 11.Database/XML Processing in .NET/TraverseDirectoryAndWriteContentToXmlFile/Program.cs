namespace TraverseDirectoryAndWriteContentToXmlFile
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../directory.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string picturePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                writer.WriteStartDocument();
                writer.WriteStartElement("Desktop");
                Traverse(picturePath, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("result saved as dir.xml");
        }

        static void Traverse(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}