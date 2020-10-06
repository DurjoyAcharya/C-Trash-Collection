class Program {
        static Program() { 
        
        }
        public Program(int p) {
            WriteLine("Instance Constructor: "+p);
        }
        public string namedetails(string name, string dep) {
            return "Name: " + name + " Department: " + dep;
        }
        static public void Main(String[] args)
        {
            Program obj = new Program(1);
            WriteLine(obj.namedetails("Durjoy Acharya", "CSE"));
            Program ob = new Program(2);
            WriteLine(obj.namedetails("Sanjita Das", "Tourism"));
        }
        
    }