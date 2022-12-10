using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    public interface IDbObject
    {
        int Id { get; }
        string Title { get; }
    }
}
