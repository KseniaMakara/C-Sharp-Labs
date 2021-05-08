using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._3._5
{
    class HRD
    {
        public string ID { get; set; }
        public string education { get; set; }
        public string specialization { get; set; }
        public string posiion { get; set; }
        public string salary { get; set; }

        public HRD(string ID, string education, string specialization, string posiion, string salary)
        {
            this.ID = ID;
            this.education = education;
            this.specialization = specialization;
            this.posiion = posiion;
            this.salary = salary;
        }


    }
}
