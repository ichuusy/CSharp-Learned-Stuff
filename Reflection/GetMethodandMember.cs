using System;
using System.Reflection;

namespace SysReflection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Type access = typeof(String);
            MemberInfo[] info = access.GetMembers();
            foreach (var item in info)
            {
                if (item.MemberType == MemberTypes.Method)
                {
                    Console.WriteLine($"Name : {item.Name}, Declaring Type :  {item.DeclaringType}, Member Type : {item.MemberType}, ReflectedType : {item.ReflectedType}, Module : {item.Module}, Metadata token : {item.MetadataToken}");
                }
            }
            
            int value = Int32.MinValue;
            Type newType = value.GetType();
            
            // First Way
            MethodInfo[] methods = newType.GetMethods();
            
            // Second Way
            MethodInfo[] newMethods = newType.GetMethods(BindingFlags.Public);
            
            foreach (var method in methods)
            {
                if (method.IsPublic)
                {
                    Console.WriteLine($"Public Method Founded! \n" +
                                      $"Name : {method.Name}, \n" +
                                      $"Member Type {method.MemberType}, \n" +
                                      $"Declaring Type : {method.DeclaringType}, \n" +
                                      $"Is Special Name : {method.IsSpecialName}, \n" +
                                      $"Return Type : {method.ReturnType}, \n" +
                                      $"Return Parameter : {method.ReturnParameter}, \n" +
                                      $"Return Type Custom Attributes : {method.ReturnTypeCustomAttributes}, \n" +
                                      $"Calling Convention : {method.CallingConvention} , \n" +
                                      $"Assembly : {method.IsAssembly} \n");
                }   
            }
        }
    }
}
