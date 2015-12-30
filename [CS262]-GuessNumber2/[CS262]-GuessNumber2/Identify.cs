using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CS262__GuessNumber2
{
    public class Identify
    {
        public int aCount;
        public int bCount;

        public int answerNumber1;

        public int answerNumber2;

        public int answerNumber3;

        public int answerNumber4;

        public int tryNumber1;

        public int tryNumber2;

        public int tryNumber3;

        public int tryNumber4;

        public void identify()
        {
            // 開始判斷幾A幾B
            if (tryNumber1 == answerNumber1)
            {
                aCount = aCount + 1;
            }
            else if (tryNumber1 == answerNumber2)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber1 == answerNumber3)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber1 == answerNumber4)
            {
                bCount = bCount + 1;
            }
            else
            {
            }

            if (tryNumber2 == answerNumber2)
            {
                aCount = aCount + 1;
            }
            else if (tryNumber2 == answerNumber1)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber2 == answerNumber3)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber2 == answerNumber4)
            {
                bCount = bCount + 1;
            }
            else
            {
            }

            if (tryNumber3 == answerNumber3)
            {
                aCount = aCount + 1;
            }
            else if (tryNumber3 == answerNumber1)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber3 == answerNumber2)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber3 == answerNumber4)
            {
                bCount = bCount + 1;
            }
            else
            {
            }

            if (tryNumber4 == answerNumber4)
            {
                aCount = aCount + 1;
            }
            else if (tryNumber4 == answerNumber2)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber4 == answerNumber3)
            {
                bCount = bCount + 1;
            }
            else if (tryNumber4 == answerNumber1)
            {
                bCount = bCount + 1;
            }
            else
            {
            }
        }
    }
}