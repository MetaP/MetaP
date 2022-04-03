using System.Xml.Serialization;

namespace MetaP.Data.Serialization
{
    public class DataAtom : DataElement
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement()]
        public DataAtomParameter[] Parameters { get; set; }
    }
}
