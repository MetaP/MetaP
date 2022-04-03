using System.Xml.Serialization;

namespace MetaP.Data.Serialization
{
    /// <summary>Defines a data structure.</summary>
    [XmlRoot(Namespace = "MetaP/Data/Model/v1")]
    public class DataModel
    {
        [XmlElement("Atom", typeof(DataAtom))]
        //[XmlElement("Array", typeof(DataArray))]
        [XmlElement("Composite", typeof(DataComposite))]
        public DataElement? Root { get; set; }
    }
}
