namespace Lab3._1DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? course { get; set; }

        [StringLength(50)]
        public string faculty { get; set; }

        public int? rate { get; set; }
    }
}
