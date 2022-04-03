namespace MetaP.MetaModel
{
    public class MetaReal : MetaNumber
    {
        /// <summary>Enumerates the possible real implementation sizes.</summary>
        public enum ByteSize
        {
            /// <summary>4 byte.</summary>
            _4 = 4,

            /// <summary>8 byte.</summary>
            _8 = 8,

            /// <summary>16 byte.</summary>
            _16 = 16
        }

        public MetaReal(ByteSize size)
        {
            Size = size;
        }

        //public MetaReal(string name, ByteSize size) : base(name)
        //{
        //    Size = size;
        //}

        /// <summary>The size in bytes of the implementation of this type.</summary>
        public ByteSize Size { get; }
    }
}
