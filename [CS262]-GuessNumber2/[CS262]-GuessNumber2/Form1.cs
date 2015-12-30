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
            CreateNumber Answer = new CreateNumber();
            Answer.crate();
            answer[0] = Convert.ToString(Answer.createNumber1);
            answer[1] = Convert.ToString(Answer.createNumber2);
            answer[2] = Convert.ToString(Answer.createNumber3);
            answer[3] = Convert.ToString(Answer.createNumber4);
            number1 = Answer.createNumber1;
            number2 = Answer.createNumber2;
            number3 = Answer.createNumber3;
            number4 = Answer.createNumber4;

            label1.Text = "題目已經準備完成";

            haveAnswer = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AutoSearchButton_Click(object sender, EventArgs e)
        {
            CreateNumber AiSearch1 = new CreateNumber();
            AiSearch1.crate();

            if (tryTimes == 1)
            {
                Identify _1stSearch = new Identify();
                _1stSearch.answerNumber1 = AiSearch1.createNumber1;
                _1stSearch.answerNumber2 = AiSearch1.createNumber2;
                _1stSearch.answerNumber3 = AiSearch1.createNumber3;
                _1stSearch.answerNumber4 = AiSearch1.createNumber4;
                _1stSearch.tryNumber1 = number1;
                _1stSearch.tryNumber2 = number2;
                _1stSearch.tryNumber3 = number3;
                _1stSearch.tryNumber4 = number4;
                _1stSearch.identify();

                string[] answer = new string[4];
                answer[0] = Convert.ToString(AiSearch1.createNumber1);
                answer[1] = Convert.ToString(AiSearch1.createNumber2);
                answer[2] = Convert.ToString(AiSearch1.createNumber3);
                answer[3] = Convert.ToString(AiSearch1.createNumber4);
                tryNumber1label.Text = answer[0] + answer[1] + answer[2] + answer[3];
                tryTimes = tryTimes + 1;
                _1stResult.Text = Convert.ToString(_1stSearch.aCount) + "A" + Convert.ToString(_1stSearch.bCount) + "B";
            }
            else
            {
                MessageBox.Show("第一次結果已產生");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AutoSearchButton2_Click(object sender, EventArgs e)
        {
            CreateNumber AiSearch2 = new CreateNumber();
            AiSearch2.crate();

            if (tryTimes == 2)
            {
                Identify _2stSearch = new Identify();
                _2stSearch.answerNumber1 = AiSearch2.createNumber1;
                _2stSearch.answerNumber2 = AiSearch2.createNumber2;
                _2stSearch.answerNumber3 = AiSearch2.createNumber3;
                _2stSearch.answerNumber4 = AiSearch2.createNumber4;
                _2stSearch.tryNumber1 = number1;
                _2stSearch.tryNumber2 = number2;
                _2stSearch.tryNumber3 = number3;
                _2stSearch.tryNumber4 = number4;
                _2stSearch.identify();

                string[] answer = new string[4];
                answer[0] = Convert.ToString(AiSearch2.createNumber1);
                answer[1] = Convert.ToString(AiSearch2.createNumber2);
                answer[2] = Convert.ToString(AiSearch2.createNumber3);
                answer[3] = Convert.ToString(AiSearch2.createNumber4);
                tryNumber2Label.Text = answer[0] + answer[1] + answer[2] + answer[3];
                tryTimes = tryTimes + 1;
                _2ndResult.Text = Convert.ToString(_2stSearch.aCount) + "A" + Convert.ToString(_2stSearch.bCount) + "B";
            }
            else
            {
                MessageBox.Show("步驟錯誤");
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