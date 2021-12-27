using System;
using System.Collections.Generic;


namespace Lab5p.Models
{
    public partial class Pages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Start { get; set; }
        public int? End { get; set; }
        public int? MangaId { get; set; }

        public virtual Manga Jojo { get; set; }
    }
}
