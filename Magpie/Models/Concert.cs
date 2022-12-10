using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    public class Concert : IDbObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(50)]
        public string Title { get; set; }

        [NotNull]
        public DateTime Date { get; set; }

        public string Location { get; set; }

        public string Album { get; set; }
    }
}
