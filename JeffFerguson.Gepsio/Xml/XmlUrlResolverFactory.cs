using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace JeffFerguson.Gepsio.Xml
{
    /// <summary>
    /// XmlUrlResolverFactory to provide instance of XmlUrlResolvers
    /// </summary>
    public class XmlUrlResolverFactory
    {
        /// <summary>
        /// Reads document as stream
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual Stream ReadXmlDocumentStream(string path)
        {
            return File.OpenRead(path);
        }

        /// <summary>
        /// Reads the schema in given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual XmlSchema ReadSchema(string path)
        {
            var schemaReader = XmlReader.Create(path);
            return XmlSchema.Read(schemaReader, null);
        }

        /// <summary>
        /// Creates a instance of XmlUrlResolver
        /// </summary>
        /// <returns></returns>
        public virtual XmlUrlResolver CreateUrlResolver()
        {
            return new XmlUrlResolver();
        }
    }
}
