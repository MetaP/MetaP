namespace MetaP.MetaModel
{
    /// <summary>Represents a data element that can hold an integer number.</summary>
    public class MetaInteger : MetaNumber
    {
        /// <summary>Enumerates the possible integer implementation sizes.</summary>
        public enum ByteSize
        {
            /// <summary>1 byte. <see cref="MetaInteger"/> [-128, 128[ or <see cref="MetaNatural"/> [0, 256]</summary>
            _1 = 1,

            /// <summary>2 byte. <see cref="MetaInteger"/> [-32,768, 32,768[ or <see cref="MetaNatural"/> [0, 65,535]</summary>
            _2 = 2,

            /// <summary>4 byte. <see cref="MetaInteger"/> [-2,147,483,648, 2,147,483,648[ or <see cref="MetaNatural"/> [0, 4,294,967,295]</summary>
            _4 = 4,

            /// <summary>8 byte <see cref="MetaInteger"/> [-9,223,372,036,854,775,808, 9,223,372,036,854,775,808[ or <see cref="MetaNatural"/> [0, 18,446,744,073,709,551,615]</summary>
            _8 = 8
        }

        public MetaInteger(ByteSize size)
        {
            Size = size;
        }

        //public MetaInteger(string name, ByteSize size) : base(name)
        //{
        //    Size = size;
        //}

        /// <summary>The size in bytes of the implementation of this type.</summary>
        public ByteSize Size { get; }
    }
}
