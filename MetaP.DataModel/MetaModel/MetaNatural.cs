namespace MetaP.MetaModel
{
    /// <summary>Represents a data element that can hold a natural number.</summary>
    public class MetaNatural : MetaInteger
    {
        public MetaNatural(ByteSize size) : base(size)
        {
        }

        //public MetaNatural(string name, ByteSize size) : base(name, size)
        //{
        //}
    }
}
