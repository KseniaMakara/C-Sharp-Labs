﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab6.Models
{
    public partial class Files
    {
        public int Id { get; set; }
        public long? Size { get; set; }
        public DateTime? UploadDate { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
