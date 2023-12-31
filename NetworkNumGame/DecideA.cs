﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkNumGame
{
    class DecideA
    {
        private const int init = 1; // 初期値
        private int Threshold = 10; // しきい値、色々変えよう！！
        
        private int NowA = init; // 現在のA
        private int Q = 0; // 入力されたQ

        private int count = 0;
        private int OutFlag = 0;

        public DecideA()
        {

        }

        public int GetNowA()
        {
            return NowA;
        }
        public int GetQ()
        {
            return Q;
        }
        public void SetQ(int Q)
        {
            this.Q = Q;
        }
        public void SetThreshold(int Threshold)
        {
            this.Threshold = Threshold;
        }

        // Aを増加させる関数、ここを弄る必要あり
        // 加算＋指数関数システム導入
        public void IncreaseA()
        {
            count++;

            if (count < Threshold && OutFlag == 0)
            {
                IncreaseExp(count);
            }
            else
            {
                IncreaseLinear();
            }
        }

        // Aを1ずつ増やす簡単なアルゴリズム
        //public void IncreaseA()
        //{
        //    NowA++;
        //}


        // Aを初期値に戻す
        public void ResetA()
        {
            NowA = init;
            count = 0;
        }

        // アウトフラグを立てる
        public void SetOutFlag()
        {
            OutFlag = 1;
        }
        // アウトフラグを取り除く
        public void RemoveOutFlag()
        {
            OutFlag = 0;
        }

        // 線形に１ずつ増やす
        private void IncreaseLinear()
        {
            NowA = NowA + 1;
        }

        // 指数関数的に増やす
        private void IncreaseExp(int i)
        {
            NowA = (int)Math.Exp(i);
        }

        
    }
}
