using System;
using System.Collections.Generic;

namespace Lab5p.Models
{
    public partial class Manga
    {
        public Manga()
        {
            Pages = new HashSet<Pages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Pages { get; set; }
        public double? Price { get; set; }
        public DateTime? Published { get; set; }

        public virtual ICollection<Pages> Pages { get; set; }
    }
}
