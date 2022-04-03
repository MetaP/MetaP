using System.Xml.Serialization;

namespace MetaP.Data.Model1
{
    /// <summary>Defines a data structure.</summary>
    [XmlRoot(Namespace = "MetaP/Data/Model/v1")]
    public class DataModel
    {
        [XmlElement("root")]
        public DataElement? Root { get; set; }
    }
}
