using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressionLab_13_21
{
    class TArProgression
    {
        public int first_el { get; set; }
        public int [] progression { get; set; }
        public double d { get; set; }

        public TArProgression(int first_el, double d)
        {
            this.first_el = first_el;
            this.d = d;
        }

        public TArProgression()
        {
            first_el = 1;
            d = 1;
        }
        public TArProgression(TArProgression t)
        {
            this.first_el = t.first_el;
            this.d = t.d;
        }
        public int[] EnterPrint(int n)
        {
            Random rnd = new Random();
            
            int[] progression = new int[n + 1];

            for (int i = 0; i < n+1; i++)
            {
                if (i==0)
                    progression[i] = first_el;
                else
                progression[i] = rnd.Next(2, 65);
            Console.WriteLine(progression[i]);
            }
            return progression;
        }
        
        public int IndexOf (int index  )
        {
            foreach (int i in progression)
                if (i==index)
                    return progression[i];
            return progression[2];
        }

    }

}
