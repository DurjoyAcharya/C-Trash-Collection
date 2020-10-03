using System;
using static System.Console;
using System.Linq;
using System.Reflection;

namespace Competitive
{
    class Program:Myclass
    {
        static void Main(string[] args)
        {
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int MethodCount = 0;
                foreach (var t in a.DefinedTypes)
                {
                    MethodCount += t.GetMethods().Count();
                }
                WriteLine(
                    "{0:NO} types with {1:NO} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: MethodCount,
                    arg2: r.Name);
            }
            
        }
        
    }
}
