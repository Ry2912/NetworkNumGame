using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkNumGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DecideA decidea;
        private int Score = 0;
        private int flag = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextResult.AppendText("現在の点数 : " + 0);
            decidea = new DecideA();
        }

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            decidea.SetQ((int)NUD.Value);
            decidea.SetThreshold((int)NUDthreshold.Value);

            for (int i = 0; i < 100000; i++)
            {
                if (decidea.GetNowA() >= decidea.GetQ())
                {
                    if (decidea.GetNowA() > decidea.GetQ())
                    {
                        Score = Score - ((decidea.GetNowA() - decidea.GetQ()) * 200);
                        TextMemo.AppendText((i + 1) + "   A = " + decidea.GetNowA() + " out / 新しいQを入力\r\n");

                        decidea.SetOutFlag(); // outフラグをDecideAクラスに立てる
                    }
                    else
                    {
                        Score = Score + decidea.GetNowA();
                        TextMemo.AppendText((i + 1) + "   A = " + decidea.GetNowA() + " success / 新しいQを入力\r\n");

                        decidea.RemoveOutFlag(); // outフラグをDecideAクラスから消す
                    }

                    TextResult.Clear();
                    TextResult.AppendText("現在の点数 : " + Score);

                    
                    
                    decidea.ResetA(); // アウトおよび正解になったのでAを初期値に
                    

                    await Task.Run(() =>
                    {
                        while (true)
                        {
                            if (flag == 1)
                            {
                                decidea.SetQ((int)NUD.Value);
                                flag = 0;
                                break;
                            }
                        }
                    });
                }
                else
                {
                    Score = Score + decidea.GetNowA();


                    // ↓これ表示させると時間食う
                    //TextResult.Clear();
                    //TextResult.AppendText("現在の点数 : " + Score);
                    // TextMemo.AppendText((i + 1) + "   A = " + decidea.GetNowA() + " safe\r\n");

                    decidea.IncreaseA();
                }

            }

            TextMemo.AppendText("end\r\n");
            
            TextResult.Clear();
            TextResult.AppendText("現在の点数 : " + Score);
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            flag = 1;
        }
    }
}
