namespace MetaP.MetaModel
{
    /// <summary>Represents a part of a <see cref="MetaComposite"/> identified by a key.</summary>
    public class MetaCompositePart
    {
        public MetaCompositePart(string key, IMetaElement element)
        {
            Key = key;
            Element = element;
        }

        /// <summary>A key that identifies this part among its siblings.</summary>
        public string Key { get; }

        /// <summary>The data element type of this part.</summary>
        public IMetaElement Element { get; }


        //public MetaCompositePart(string key, MetaElement element)
        //{
        //    Key = key;
        //    Element = element;
        //}

        ///// <summary>A key that identifies this part among its siblings.</summary>
        //public string Key { get; }

        ///// <summary>The data element type of this part.</summary>
        //public MetaElement Element { get; }
    }
}
