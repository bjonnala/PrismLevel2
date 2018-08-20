using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismLevel2
{
    class Floor
    {
        private int Floornumber;

        public Floor(int v)
        {
            this.Floornumber = v;
        }

        public int? Elevator1Floornumber { get; set; }
        public int? Elevator2Floornumber { get; set; }

    }
}
