using System;
using static System.Console;
/*Durjoy_Acharya<da_durjoy@outlook.com>*/

namespace Competitive
{
    class Program : Myclass
    {
        enum color { Yellow = 1, Blue, Green };
        static DateTime isDate = DateTime.Now;
        static void Main(string[] args)
        {
            Console.Clear();
            WriteLine("Standared Numeric Format Specifiers");
            WriteLine(
                "(C)  Currency :.........................{0:C}\n" +
                "(D)  Decimal :..........................{0:D}\n" +
                "(E)  Scientific :.......................{1:E}\n" +
                "(F)  Fixed Point :......................{1:F}\n" +
                "(G)  General :..........................{0:G}\n" +
                "    (default):............{0} (default = 'G')\n" +
                "(N)  Number :...........................{0:N}\n" +
                "(P)  Percent :..........................{1:P}\n" +
                "(R)  Round Trtip :......................{1:R}\n" +
                "(X)  Hexadecimal :......................{0:X}\n",
                -123, -321.54f
                );
            //...........................................................................//
            WriteLine("Standared DateTime Format Specifiers");
            WriteLine(
                "(d)  Short date :.........................{0:d}\n" +
                "(D)  Long date :..........................{0:D}\n" +
                "(t)  Short time :.........................{0:t}\n" +
                "(T)  Long time :..........................{0:T}\n" +
                "(f)  Full date/Short time :...............{0:f}\n" +
                "(F)  Full date/Long time :................{0:F}\n" +
                "(g)  General date/Short time :............{0:g}\n" +
                "    (default):..............{0} (default = 'G')\n" +
                "(M)  Month................................{0:M}\n" +
                "(R)  RFC1123 :............................{0:R}\n" +
                "(s)  Shortable :..........................{0:s}\n" +
                "(S)  Universal shortable :................{0:u}(invariant)\n" +
                "(U)  Full DateTime :......................{0:U}\n" +
                "(Y)  Year :...............................{0:Y}\n" ,
                isDate
                );
            //..........................................................//
            WriteLine("Standard Enumeration Format Specifiers");
            WriteLine(
                "(G) General:..................................{0:G}\n" +
                "    (default):................. {0} (default = 'G')\n" +
                "(F) Flags:. ...............{0:F} (flags or integer)\n" +
                "(D) Decimal number:.......................... {0:D}\n" +
                "(X) Hexadecimal:...............................{0:X}\n",
                color.Green);
            ReadLine();
        }
    }
}
