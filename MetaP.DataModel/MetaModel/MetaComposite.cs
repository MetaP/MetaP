namespace MetaP.MetaModel
{
    /// <summary>Represents a data element that is composed of zero or more data elements.</summary>
    public class MetaComposite : IMetaElement
    {
        public MetaComposite(string name, MetaCompositePart[] parts) // : base(name)
        {
            Name = name;
            Parts = parts;
        }

        public string Name { get; }

        public MetaCompositePart[] Parts { get; }
    }
}
