using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lab_00
{
    class Sum
    {
        public static int SumRange(int num1, int num2)
        {
            int sum = 0;

            if (num1 <= num2)
            {
                while (num1 <= num2)
                {
                    sum += num1;
                    ++num1;
                }
            }
            else if (num2 <= num1)
            {
                while (num2 <= num1)
                {
                    sum += num2;
                    ++num2;
                }
            }


            return sum;
        }

        public static void TestSumRange()
        {
            Debug.Assert(SumRange(1, 4) == 10);
            Debug.Assert(SumRange(1, 5) == 15);
            Debug.Assert(SumRange(5, 7) == 18);
            Debug.Assert(SumRange(10, 11) == 21);
            Debug.Assert(SumRange(5, 4) == 9);
        }
    }
}
