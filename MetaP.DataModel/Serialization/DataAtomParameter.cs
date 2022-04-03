using System.Xml.Serialization;

namespace MetaP.Data.Serialization
{
    public class DataAtomParameter
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
