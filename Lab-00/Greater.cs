using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
