namespace MetaP.Data.Model1
{
    /// <summary>Represents a data atom, a non-composite ("atomic") element of a data structure.</summary>
    public class DataAtom : DataElement
    {
        /// <summary>The type of this <see cref="DataAtom"/>.</summary>
        public DataType? Type { get; set; }
    }
}
