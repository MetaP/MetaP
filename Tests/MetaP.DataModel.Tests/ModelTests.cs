using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml.Serialization;

namespace MetaP.Data.Model
{
    /// <summary>Contains unit test about data models.</summary>
    [TestClass]
    public class ModelTests
    {
        //private static IDataElement CreateDataModel()
        //{
        //    DataAtom string30 = new DataAtom("String", DataAtom.Parameter("MaxLength", 30));
        //    DataAtom string100 = new DataAtom("String", DataAtom.Parameter("MaxLength", 100));

        //    DataComposite address = new DataComposite(
        //        new KeyValuePair<string, IDataElement>("Line1", string100)
        //    );

        //    DataComposite person = new DataComposite(
        //        DataComposite.Element("FirstName", string30),
        //        DataComposite.Element("LastName", string30),
        //        DataComposite.Element("Address", address)
        //    );

        //    return person;
        //}

        private static readonly DataElementFactory Factory = new();

        private static IDataElement CreateDataModel()
        {
            DataAtom string30 = Factory.CreateAtom("String(30)");
            DataAtom string100 = Factory.CreateAtom("String(100)");

            //DataComposite address = new DataComposite(
            //    new KeyValuePair<string, IDataElement>("Line1", string100)
            //);

            DataComposite address = Factory.CreateComposite(
                Factory.CreatePart("Line1", string100)
            );

            //DataComposite person = new DataComposite(
            //    DataComposite.Element("FirstName", string30),
            //    DataComposite.Element("LastName", string30),
            //    DataComposite.Element("Address", address)
            //);

            DataComposite person = Factory.CreateComposite(
                Factory.CreatePart("FirstName", string30),
                Factory.CreatePart("LastName", string30),
                Factory.CreatePart("Address", address)
            );

            return person;
        }

        /// <summary>Tests data model serialization.</summary>
        [TestMethod]
        public void Serialize()
        {
            IDataElement model = CreateDataModel();
            XmlSerializer serializer = new XmlSerializer(typeof(DataComposite));
            string path = @"C:\Temp\MetaP\DataModel.xml";
            using (FileStream stream = File.Open(path, FileMode.Create))
            {
                serializer.Serialize(stream, model);
            }
        }
    }
}
