class program{
	public static void Main(string[] args)
        {
            do
            {
                Write("\nPress any key to combination: ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                Write("Key: {0}, char: {1}, Modifiers: {2}",
                    arg0: key.Key,
                    arg1: key.KeyChar,
                    arg2: key.Modifiers);
            } while (true);
        }	
}