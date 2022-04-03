namespace MetaP.MetaModel
{
    /// <summary>Represents a data element that can hold a text with a maximum length.</summary>
    public class MetaString : IMetaElement
    {
        public MetaString(int maxLength)
        {
            MaxLength = maxLength;
        }

        //public MetaString(string name, int maxLength) : base(name)
        //{
        //    MaxLength = maxLength;
        //}

        public int MaxLength { get; }
    }
}
