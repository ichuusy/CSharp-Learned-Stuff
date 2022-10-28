using System;
using System.Reflection;

namespace SysReflection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Program);
            MethodInfo methodInfo = type.GetMethod("Run");
            
            // First way
            object o = Activator.CreateInstance(type);
            
            // Second way
            Program program = new Program();
            methodInfo.Invoke(program, null);
            methodInfo.Invoke(o, null);
        }

        public void Run()
        {
            Console.WriteLine("Worked.");
        }
    }
}
