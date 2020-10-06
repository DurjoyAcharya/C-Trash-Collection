class Program {
  
        static public void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            WriteLine("Intial value of a is: {0}",a);
            WriteLine("Intial value of a is: {0}", b);
            additionValue(a);
            WriteLine("Value after calling method is: {0}",a);
            SubstructionValue(ref b);
            WriteLine("Value after reference parameter calling method is: {0}",b);
        }
        public static void additionValue(int a) {
            a += 10;
        }
        public static void SubstructionValue(ref int b) {
            b -= 5;
        }
        
    }