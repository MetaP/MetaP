using System.Xml.Serialization;

namespace MetaP.Data.Model
{
    internal class DataArray : IDataElement
    {
        /// <summary>Initializes a new <see cref="DataArray"/> instance.</summary>
        /// <param name="itemType">The data structure shared by all items of the array.</param>
        internal DataArray(IDataElement itemType)
        {
            ItemType = itemType;
        }

        /// <summary>The data structure shared by all items of the array.</summary>
        [XmlElement("type")]
        public IDataElement ItemType { get; }
    }
}
