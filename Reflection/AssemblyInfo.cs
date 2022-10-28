using System;
using System.Reflection;

namespace SysReflection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // First way
            AppDomain app = AppDomain.CurrentDomain;
            Assembly[] asm = app.GetAssemblies();
            Console.WriteLine(asm.Length);
            for (int i = 0; i < asm.Length; i ++)
            {
                Console.WriteLine($"Assembly; name {asm[i].FullName}, location {asm[i].Location}, entry point {asm[i].EntryPoint}");
            }
            
            // Second way
            Console.WriteLine($"--------------------------------");
            Assembly data = Assembly.LoadFrom(@"/usr/lib/mono/4.5/mscorlib.dll");
            Console.WriteLine(data.Location);
            Console.WriteLine(data.CodeBase);
            
            // Third way
            Console.WriteLine($"--------------------------------");
            Assembly test = Assembly.GetExecutingAssembly();
            Console.WriteLine(test.Location);
            Console.WriteLine(test.CodeBase);
            foreach (var i in test.Modules)
            {
                Console.WriteLine(i);
            }
        }
    }
}
