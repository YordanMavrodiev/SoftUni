using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public interface ICheck
    {
        string ID { get; }
        public void Check(string lastdigits);
    }
}
