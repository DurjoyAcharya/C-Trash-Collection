class Program
    {
        
        public static void Main(string[] args)
        {
            WriteLine("-----------------------------------------------------------------");
            WriteLine("Type         Byte(s) of Memory           Min                  Max");
            WriteLine("-----------------------------------------------------------------");
            WriteLine($"sbyte             {sizeof(sbyte)}                     {sbyte.MinValue}                 {sbyte.MaxValue}");
            WriteLine($"byte              {sizeof(byte)}                      {byte.MinValue}                  {byte.MaxValue}");
            WriteLine($"short             {sizeof(short)}                     {short.MinValue}                 {short.MaxValue}");
            WriteLine($"ushort            {sizeof(ushort)}                    {ushort.MinValue}                {ushort.MaxValue}");
            WriteLine($"int               {sizeof(int)}                       {int.MinValue}                   {int.MaxValue}");
            WriteLine($"uint              {sizeof(uint)}                       {uint.MinValue}                 {uint.MaxValue}");
            
            WriteLine($"long              {sizeof(long)}                      {long.MinValue}                  {long.MaxValue}");
            WriteLine($"ulong             {sizeof(ulong)}                     {ulong.MinValue}                 {ulong.MaxValue}");
            WriteLine($"float             {sizeof(float)}                     {float.MinValue}                 {float.MaxValue}");
            WriteLine($"double            {sizeof(double)}                    {double.MinValue}                {double.MaxValue}");
            WriteLine($"decimal           {sizeof(decimal)}                   {decimal.MinValue}               {decimal.MaxValue}");
            WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }