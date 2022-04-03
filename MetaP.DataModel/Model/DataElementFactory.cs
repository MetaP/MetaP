namespace MetaP.Data.Model
{
    public class DataElementFactory
    {
        //public static KeyValuePair<string, IDataElement> CreateElement(string key, IDataElement element) => new KeyValuePair<string, IDataElement>(key, element);

        //public struct Component
        //{
        //    internal Component(string name, IDataElement element)
        //    {
        //        Name = name;
        //        Element = element;
        //    }

        //    public string Name { get; }
        //    public IDataElement Element { get; }
        //}

        public DataAtom CreateAtom(string description)
        {
            if (description.StartsWith("String"))
            {
                // "String(30)"
                if (int.TryParse(description.AsSpan(7, description.Length - 8), out int maxLength))
                {
                    return new DataAtom("String", Parameter("MaxLength", maxLength));
                }
            }

            throw new NotImplementedException();
        }

        public DataCompositePart CreatePart(string name, IDataElement element)
        {
            return new DataCompositePart(name, element);
        }

        public DataComposite CreateComposite(params DataCompositePart[] components)
        {
            return new DataComposite(components);
        }

        private static KeyValuePair<string, object> Parameter(string key, object value) => new(key, value);
    }
}
