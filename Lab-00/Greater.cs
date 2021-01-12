using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lab_00
{
    public static class Greater
    {
        public static int Greatest(int num1, int num2)
        {
            int greatest = 0;

            if (num1 >= num2)
            {
                greatest = num1;
            }
            else if (num2 > num1)
            {
                greatest = num2;
            }

            return greatest;
        }

        public static void TestGreatest()
        {
            Debug.Assert(Greatest(1, 2) == 2);
            Debug.Assert(Greatest(-1, 7) == 7);
            Debug.Assert(Greatest(5, 99) == 99);
            Debug.Assert(Greatest(5, 5) == 5);
            Debug.Assert(Greatest(251, 2) == 251);
            Debug.Assert(Greatest(102, 47) == 102);
        }
    }
}
