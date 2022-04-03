namespace MetaP.Data.Model
{
    /// <summary>Represents a data type composed of zero, one or more named child data elements.</summary>
    /// <remarks>All child elements of a <see cref="DataComposite"/> must have different names.</remarks>
    public class DataComposite : IDataElement
    {
        //public static KeyValuePair<string, IDataElement> Element(string key, IDataElement element) => new KeyValuePair<string, IDataElement>(key, element);

        //public DataComposite(params KeyValuePair<string, IDataElement>[] elements)
        //{
        //    _elements = new Dictionary<string, IDataElement>(elements);
        //}

        internal DataComposite(params DataCompositePart[] elements)
        {
            _elements = new Dictionary<string, IDataElement>(elements.Select(e => new KeyValuePair<string, IDataElement>(e.Name, e.Element)));
        }

        public IDataElement this[string name]
        { 
            get { return _elements[name]; }
        }

        private readonly IDictionary<string, IDataElement> _elements;
    }
}
