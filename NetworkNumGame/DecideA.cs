using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNumGame
{
    class DecideA
    {
        public int NowA = 1;
        public int Q = 0;
        
        public void IncreaseA()
        {
            NowA = NowA + 1;
        }

        public void ResetA()
        {
            NowA = 1;
        }
    }
}
