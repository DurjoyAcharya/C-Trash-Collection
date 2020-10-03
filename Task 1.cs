 static void Main(string[] args)
        {
            string str = string.Empty;
            int i = 0;
            do
            {
                WriteLine("Enter Your Password");
            str = ReadLine();
                i++;
                if (i == 3) {
                    break;
                }
            } while (str != "12345");
            if (i <= 3 && str=="12345")
            {
                WriteLine("Password Matched!");
            }
            else {
                WriteLine("!Failed, You Are Enterd {0} times or above ",i);
            }
            
                   
        }