using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Competitive
{
    class Myclass
    {
        protected int add(int a, int b)
        {
            return a + b;
        }
        protected int add(int a, int b,int c)
        {
            return a + b+c;
        }
        protected int add(int a, int b,int c,int d)
        {
            return a + b + c + d;
        }
        protected int square(int a)
        {
            return a * a ;
        }
        protected int Cube(int a)
        {
            return a * a * a;
        }
        public void MyBike()
        {
            Console.WriteLine("CDR-80 Is MyBike");
        }
        static void Timestable(byte number)
        {
            WriteLine($"This is table {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }
        static void RunTimestable()
        {
            bool isNumber;
            do
            {
                Write("Enter a Number between 0 to 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    Timestable(number);
                }
                else
                {
                    WriteLine("!You did not enter a valid number");
                }
            } while (isNumber);
        }
    }
}
