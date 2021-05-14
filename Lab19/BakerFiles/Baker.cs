using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    [Serializable]
    class Baker
    {
        public string shop;
        public string adress;
        public int rate;
        public string specialization;

        
        
        public Baker(string shop, string adress, int rate, string specialization)
        {
            this.shop = shop;
            this.adress = adress;
            this.rate = rate;
            this.specialization = specialization;
        }
    }
}
