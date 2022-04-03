using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaP.Data.Serialization
{
    public class DataComposite : DataElement
    {

        public DataCompositePart[] Parts { get; set; }
    }
}
