using System;


namespace Lab_00
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Please enter integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The greatest number is ");
            Console.Write(Greater.Greatest(num1, num2));
        }
    }
}
