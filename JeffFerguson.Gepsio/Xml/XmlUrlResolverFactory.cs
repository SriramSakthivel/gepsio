using System.Xml;

namespace JeffFerguson.Gepsio.Xml
{
    /// <summary>
    /// XmlUrlResolverFactory to provide instance of XmlUrlResolvers
    /// </summary>
    public class XmlUrlResolverFactory
    {
        static XmlUrlResolverFactory()
        {
            Instance = new XmlUrlResolverFactory();
        }

        /// <summary>
        /// XmlUrlResolverFactory.Factory that will be used to download schemas
        /// </summary>
        public static XmlUrlResolverFactory Instance { get; set; }

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
