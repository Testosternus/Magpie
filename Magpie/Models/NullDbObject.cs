using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    public class NullDbObject : IDbObject
    {
        public int Id => -1;
        public string Title => "Unknown object";
    }
}
