using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaP.Data.Model
{
    public struct DataCompositePart
    {
        internal DataCompositePart(string name, IDataElement element)
        {
            Name = name;
            Element = element;
        }

        public string Name { get; }
        public IDataElement Element { get; }
    }

}
