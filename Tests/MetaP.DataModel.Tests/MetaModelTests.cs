using MetaP.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml.Serialization;

namespace MetaP.MetaModel
{
    /// <summary>Contains unit test about data models.</summary>
    [TestClass]
    public class MetaModelTests
    {
        private static IMetaElement CreateMetaModel()
        {
            MetaString string30 = new MetaString(30);
            MetaString string100 = new MetaString(100);

            MetaComposite address = new MetaComposite("Address", new[] {
                new MetaCompositePart("Line1", string100)
            });

            MetaComposite person = new MetaComposite("Person", new[] {
                new MetaCompositePart("FirstName", string30),
                new MetaCompositePart("LastName", string30),
                new MetaCompositePart("Address", address),
            });

            return person;
        }

        /// <summary>Tests data model serialization.</summary>
        [TestMethod]
        public void Serialize()
        {
            IMetaElement model = CreateMetaModel();
            XmlSerializer serializer = new XmlSerializer(typeof(DataComposite));
            string path = Utility.GetOutputPath("MetaModel.xml");
            using (FileStream stream = File.Open(path, FileMode.Create))
            {
                serializer.Serialize(stream, model);
                serializer.Deserialize()
            }
        }
    }
}
