using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicsDemo
{
    class Complex
    {
        private int real, img;
        public Complex(int r,int i)
        {
            real = r;
            img = i;
        }
        public int GetRealValue() {
            return real;
        }
        public int GetImgvalue() {
            return img;
        }
        public static void update(ref Complex obj) {
            obj.real += 5;
            obj.img += 3;
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            Complex C = new Complex(3,5);
            //Complex mnumber printing without Reference value
            WriteLine("Complex Number C = "+C.GetRealValue()+" + "+C.GetImgvalue()+"i");
            Complex.update(ref C);
            //Complex mnumber printing with updating Reference value
            WriteLine("After updating Reference value");
            WriteLine("Complex Number C = " + C.GetRealValue() + " + " + C.GetImgvalue() + "i");
        }
    }
}
