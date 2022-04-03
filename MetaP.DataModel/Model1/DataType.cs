using System.Xml.Serialization;

namespace MetaP.Data.Model1
{
    /// <summary>Represents a data type.</summary>
    /// <remarks>"Integer{Signed=false,NumberOfBytes=2}</remarks>
    public class DataType
    {
        [XmlAttribute]
        public string Name { get; set; } = string.Empty;

        /// <summary>A dictionary with of zero or more parameters that in combination with the <see cref="Name"/> fully define
        /// this <see cref="DataType"/>.</summary>
        [XmlElement]
        public IDictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
    }
}
