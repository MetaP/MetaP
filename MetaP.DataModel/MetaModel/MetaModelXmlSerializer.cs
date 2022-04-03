namespace MetaP.MetaModel
{
    public class MetaModelXmlSerializer
    {

        public void Serialize(Stream stream, IMetaElement model)
        {

        }

        public TModel Desirealize<TModel>(Stream stream) where TModel : IMetaElement
        {
            throw new NotImplementedException();
        }
    }
}
