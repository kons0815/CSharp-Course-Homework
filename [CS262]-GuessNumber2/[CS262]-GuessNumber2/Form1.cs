using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CS262__GuessNumber2
{
    public partial class Form1 : Form
    {
        public int number1;
        public int number2;
        public int number3;
        public int number4;
        public int tryNumber1;
        public int tryNumber2;
        public int tryNumber3;
        public int tryNumber4;
        public int tryTimes = 1;
        public int aCount = 0;
        public int bCount = 0;
        public int stepA = 0;
        public int stepB = 0;
        public bool haveAnswer = false;
        public int playerNumber1;
        public int playerNumber2;
        public int playerNumber3;
        public int playerNumber4;
        public int playerNumberCount;
        public string stepTemp;
        public string[] answer = new string[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createAnswer_Click(object sender, EventArgs e)
        {
            Random x1 = new Random();
            number1 = x1.Next(1, 9);
            //開始生產第2個數字
            for (int i = 0; i == 0; )
            {
                number2 = x1.Next(1, 9);
                if (number1 == number2)
                {
                    number2 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }

            //開始生產第3個數字
            for (int i = 0; i == 0; )
            {
                number3 = x1.Next(1, 9);
                if (number3 == number1)
                {
                    number3 = x1.Next(1, 9);
                }
                else if (number3 == number2)
                {
                    number3 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }

            //開始生產第4個數字
            for (int i = 0; i == 0; )
            {
                number4 = x1.Next(1, 9);
                if (number4 == number1)
                {
                    number4 = x1.Next(1, 9);
                }
                else if (number4 == number2)
                {
                    number4 = x1.Next(1, 9);
                }
                else if (number4 == number3)
                {
                    number4 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }

            answer[0] = Convert.ToString(number1);
            answer[1] = Convert.ToString(number2);
            answer[2] = Convert.ToString(number3);
            answer[3] = Convert.ToString(number4);
            label1.Text = "題目已經準備完成";

            haveAnswer = true;
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void AutoSearchButton_Click(object sender, EventArgs e)
        {

            Random x1 = new Random();
            if (haveAnswer == false)
            {
                tryNumber1label.Text = "還沒產生答案";
            }
            else if (tryTimes == 1)
            {
                tryNumber1 = x1.Next(1, 9);
                //開始生產第2個數字
                for (int i = 0; i == 0; )
                {
                    tryNumber2 = x1.Next(1, 9);
                    if (tryNumber1 == tryNumber2)
                    {
                        tryNumber2 = x1.Next(1, 9);
                    }
                    else
                    {
                        i++;
                    }
                }

                //開始生產第3個數字
                for (int i = 0; i == 0; )
                {
                    tryNumber3 = x1.Next(1, 9);
                    if (tryNumber3 == tryNumber1)
                    {
                        tryNumber3 = x1.Next(1, 9);
                    }
                    else if (tryNumber3 == tryNumber2)
                    {
                        tryNumber3 = x1.Next(1, 9);
                    }
                    else
                    {
                        i++;
                    }
                }

                //開始生產第4個數字
                for (int i = 0; i == 0; )
                {
                    tryNumber4 = x1.Next(1, 9);
                    if (tryNumber4 == tryNumber1)
                    {
                        tryNumber4 = x1.Next(1, 9);
                    }
                    else if (tryNumber4 == tryNumber2)
                    {
                        tryNumber4 = x1.Next(1, 9);
                    }
                    else if (tryNumber4 == tryNumber3)
                    {
                        tryNumber4 = x1.Next(1, 9);
                    }
                    else
                    {
                        i++;
                    }
                }


                // 開始判斷幾A幾B
                if (tryNumber1 == number1)
                {
                    aCount = aCount + 1;
                }
                else if (tryNumber1 == number2)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber1 == number3)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber1 == number4)
                {
                    bCount = bCount + 1;
                }
                else
                {
                }

                if (tryNumber2 == number2)
                {
                    aCount = aCount + 1;
                }
                else if (tryNumber2 == number1)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber2 == number3)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber2 == number4)
                {
                    bCount = bCount + 1;
                }
                else
                {
                }

                if (tryNumber3 == number3)
                {
                    aCount = aCount + 1;
                }
                else if (tryNumber3 == number1)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber3 == number2)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber3 == number4)
                {
                    bCount = bCount + 1;
                }
                else
                {
                }


                if (tryNumber4 == number4)
                {
                    aCount = aCount + 1;
                }
                else if (tryNumber4 == number2)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber4 == number3)
                {
                    bCount = bCount + 1;
                }
                else if (tryNumber4 == number1)
                {
                    bCount = bCount + 1;
                }
                else
                {
                }
                string[] answer = new string[4];
                answer[0] = Convert.ToString(tryNumber1);
                answer[1] = Convert.ToString(tryNumber2);
                answer[2] = Convert.ToString(tryNumber3);
                answer[3] = Convert.ToString(tryNumber4);
                tryNumber1label.Text = answer[0] + answer[1] + answer[2] + answer[3];
                tryTimes = tryTimes + 1;
                _1stResult.Text = Convert.ToString(aCount) + "A" + Convert.ToString(bCount) + "B";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AutoSearchButton2_Click(object sender, EventArgs e)
        {
            Random x1 = new Random();
            if (tryTimes != 2)
            {
                _2ndResult.Text = "尚無第一次解答結果";
            }
            else
            {
                if (aCount == 4)
                {
                    _2ndResult.Text = "已有標準解答";
                }
                else if (aCount == 3)
                {

                }
            }
  
        }

        private void inputAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerTryButton_Click(object sender, EventArgs e)
        {

            if (haveAnswer == false)
            {
                identifyLabel.Text = "還沒產生答案";
            }
            else
            {
       
            int test;
            if (int.TryParse(inputAnswer1.Text + inputAnswer2.Text + inputAnswer3.Text + inputAnswer4.Text, out test))
            {
                playerNumber1 = Int32.Parse(inputAnswer1.Text);
                playerNumber2 = Int32.Parse(inputAnswer2.Text);
                playerNumber3 = Int32.Parse(inputAnswer3.Text);
                playerNumber4 = Int32.Parse(inputAnswer4.Text);
                if (playerNumber1 > 10)
                {
                    identifyLabel.Text = "請輸入小於10的數字";
                }
                else if (playerNumber2 > 10)
                {
                    identifyLabel.Text = "請輸入小於10的數字";
                }
                else if (playerNumber3 > 10)
                {
                    identifyLabel.Text = "請輸入小於10的數字";
                }
                else if (playerNumber4 > 10)
                {
                    identifyLabel.Text = "請輸入小於10的數字";
                }

                else if (playerNumber1 == playerNumber2)
                {
                    identifyLabel.Text = "數字重複了";
                }
                else if (playerNumber1 == playerNumber3)
                {
                    identifyLabel.Text = "數字重複了";
                }
                else if (playerNumber1 == playerNumber4)
                {
                    identifyLabel.Text = "數字重複了";
                }
                else if (playerNumber2 == playerNumber3)
                {
                    identifyLabel.Text = "數字重複了";
                }
                else if (playerNumber2 == playerNumber4)
                {
                    identifyLabel.Text = "數字重複了";
                }
                else if (playerNumber3 == playerNumber4)
                {
                    identifyLabel.Text = "數字重複了";
                }
                //  MessageBox.Show(Convert.ToString(playerNumber1) + Convert.ToString(playerNumber2) + Convert.ToString(playerNumber3) + Convert.ToString(playerNumber4));

                else
                {
                    if (playerNumber1 == number1)
                    {
                        aCount = aCount + 1;
                    }
                    else if (playerNumber1 == number2)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber1 == number3)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber1 == number4)
                    {
                        bCount = bCount + 1;
                    }
                    else
                    {
                    }

                    if (playerNumber2 == number2)
                    {
                        aCount = aCount + 1;
                    }
                    else if (playerNumber2 == number1)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber2 == number3)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber2 == number4)
                    {
                        bCount = bCount + 1;
                    }
                    else
                    {
                    }

                    if (playerNumber3 == number3)
                    {
                        aCount = aCount + 1;
                    }
                    else if (playerNumber3 == number1)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber3 == number2)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber3 == number4)
                    {
                        bCount = bCount + 1;
                    }
                    else
                    {
                    }


                    if (playerNumber4 == number4)
                    {
                        aCount = aCount + 1;
                    }
                    else if (playerNumber4 == number2)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber4 == number3)
                    {
                        bCount = bCount + 1;
                    }
                    else if (playerNumber4 == number1)
                    {
                        bCount = bCount + 1;
                    }
                    else
                    {
                    }


                    describeLabel.Text = stepTemp + "玩家輸入" + inputAnswer1.Text + inputAnswer2.Text + inputAnswer3.Text + inputAnswer4.Text + "得到結果" + Convert.ToString(aCount) + "A" + Convert.ToString(bCount) + "B" + "\r\n";
                    stepTemp = describeLabel.Text;
                    aCount = 0;
                    bCount = 0;
                }
                }



            }

          
        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = answer[0] + answer[1] + answer[2] + answer[3];
        }



    }
}
