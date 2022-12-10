using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magpie.Models
{
    public class FoodPlace : IDbObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime? LastChosen { get; set; }

        [Ignore]
        public int DaysAgo
        {
            get
            {
                return LastChosen.HasValue ? (DateTime.Now.Subtract(LastChosen.Value).Days) : -1;
            }
        }
    }
}
