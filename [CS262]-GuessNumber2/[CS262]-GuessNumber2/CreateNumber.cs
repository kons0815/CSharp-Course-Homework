using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CS262__GuessNumber2
{
    public class CreateNumber
    {
        private Random x1 = new Random();
        public int createNumber1;
        public int createNumber2;
        public int createNumber3;
        public int createNumber4;

        public void crate()
        {
            createNumber1 = x1.Next(1, 9);

            //開始生產第2個數字
            for (int i = 0; i == 0; )
            {
                createNumber2 = x1.Next(1, 9);
                if (createNumber1 == createNumber2)
                {
                    createNumber2 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }

            //開始生產第3個數字
            for (int i = 0; i == 0; )
            {
                createNumber3 = x1.Next(1, 9);
                if (createNumber3 == createNumber1)
                {
                    createNumber3 = x1.Next(1, 9);
                }
                else if (createNumber3 == createNumber2)
                {
                    createNumber3 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }

            //開始生產第4個數字
            for (int i = 0; i == 0; )
            {
                createNumber4 = x1.Next(1, 9);
                if (createNumber4 == createNumber1)
                {
                    createNumber4 = x1.Next(1, 9);
                }
                else if (createNumber4 == createNumber2)
                {
                    createNumber4 = x1.Next(1, 9);
                }
                else if (createNumber4 == createNumber3)
                {
                    createNumber4 = x1.Next(1, 9);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}