using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNumGame
{
    class DecideA
    {
        private const int init = 1; // 初期値

        public int NowA = init;
        public int Q = 0;

        DecideA()
        {

        }

        // Aを増加させる関数、ここを弄る必要あり
        public void IncreaseA()
        {
            NowA = NowA + 1;
        }

        // Aを初期値に戻す
        public void ResetA()
        {
            NowA = init;
        }
    }
}
