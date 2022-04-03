using System.Xml.Serialization;

namespace MetaP.Data.Serialization
{
    public class DataCompositePart
    {
        [XmlAttribute("name")]
        public string Name { get; set;  }

        [XmlElement("Atom", typeof(DataAtom))]
        //[XmlElement("Array", typeof(DataArray))]
        [XmlElement("Composite", typeof(DataComposite))]
        public DataElement Element { get; set; }
    }
}
