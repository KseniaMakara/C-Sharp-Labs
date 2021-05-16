using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._3._11
{
    [Serializable]
    class Inquisition
    {
        public string name { get; set; }
        public string profession { get; set; }
        public string specialization { get; set; }
        public string status { get; set; }

        public Inquisition( string name, string profession, string specialization,string status)
        {
            this.name = name;
            this.profession = profession;
            this.specialization = specialization;
            this.status = status;

        }
    }
}
