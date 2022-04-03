using System.Xml.Serialization;

namespace MetaP.Data.Model
{
    /// <summary>>Represents an indivisible ("atomic") element of a data structure.</summary>
    /// <remarks>"Integer{Signed=false,NumberOfBytes=2}</remarks>
    public class DataAtom : IDataElement
    {
        //public struct Parameter
        //{
        //    public Parameter(string name, object value)
        //    {
        //        Name = name;
        //        Value = value;
        //    }

        //    public string Name { get; }
        //    public object Value { get; }
        //}

        //public static KeyValuePair<string, object> Parameter(string key, object value) => new KeyValuePair<string, object>(key, value);

        //public DataAtom(string name, params Parameter[] parameters)
        //{
        //    Name = name;
        //    _parameters = new Dictionary<string, object>(parameters.Select(p => new KeyValuePair<string, object>(p.Name, p.Value)));
        //}
        internal DataAtom(string type, params KeyValuePair<string, object>[] parameters)
        {
            Type = type;
            _parameters = new Dictionary<string, object>(parameters);
        }

        [XmlAttribute]
        public string Type { get; }

        public object GetParameter(string name)
        {
            return _parameters[name];
        }

        private readonly IDictionary<string, object> _parameters;
    }
}
