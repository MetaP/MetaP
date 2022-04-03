using MetaP.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MetaP.Data.Serialization
{
    /// <summary>Contains tests about data model serialization.</summary>
    [TestClass]
    public class SerializationTests
    {
        /// <summary>Tests data model serialization.</summary>
        [TestMethod]
        public void Serialize()
        {
            string path = Utility.GetOutputPath("DataAtom.xml");

            DataAtom string30 = new()
            {
                Type = "String",
                Parameters = new DataAtomParameter[]
                {
                    new() { Name = "MaxLength", Value = "30" }
                }
            };

            DataComposite person = new()
            {
                Parts = new DataCompositePart[]
                {
                    new() { Name = "FirstName", Element = string30 }
                }
            };

            DataModel model = new() { Root = person };

            XmlSerializer serializer = new XmlSerializer(typeof(DataModel));
            //using (FileStream stream = File.Open(path, FileMode.Create))
            //{
            //    serializer.Serialize(stream, atom);
            //}

            XmlWriterSettings xmlWriterSettings = new() { Indent = true };
            using (XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
            {
                serializer.Serialize(xmlWriter, model);
            }
        }
    }
}
