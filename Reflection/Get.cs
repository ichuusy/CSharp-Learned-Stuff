using System;
using System.Reflection;

namespace SysReflection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        static void MemberCall() // String
        {
            Type type = typeof(String);
            MemberInfo[] memberInfos = type.GetMembers();
            foreach (var member in memberInfos)
            {
                Console.WriteLine($"Name : {member.Name} " +
                                  $"Declaring Type : {member.DeclaringType.Name} " +
                                  $"Member Type : {member.MemberType} " +
                                  $"Reflected Type : {member.ReflectedType.Name} ");
            }
        }

        static void MethodCall() // SysReflection.Program
        {
            Type type = typeof(Program);
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine($"Name : {type.Name}");
            foreach (var method in methodInfos)
            {
                Console.WriteLine($"Name : {method.Name} " +
                                  $"Member Type : {method.MemberType} " +
                                  $"Return value : {method.ReturnType.Name} " +
                                  $"Declaring Type : {method.DeclaringType.Name} ");
            }
        }

        static void PropertyCall() // String
        {
            Type type = typeof(string);
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var property in propertyInfos)
            {
                Console.WriteLine($"Name : {property.Name} " +
                                  $"Can Read : {property.CanRead} " +
                                  $"Can Write : {property.CanWrite} " +
                                  $"Attributes : {property.Attributes} " +
                                  $"SetMethod : {property.SetMethod} " +
                                  $"Declaring Type : {property.DeclaringType.Name} ");
            }
        }

        static void FieldCall() // Boolean
        {
            Type type = typeof(Boolean);
            FieldInfo[] fieldInfos = type.GetFields();
            Console.WriteLine($"Name : {type.Name}");
            foreach (var field in fieldInfos)
            {
                Console.WriteLine($"Name: {field.Name} " +
                                  $"FieldType : {field.FieldType.Name} " +
                                  $"Is Assembly : {field.IsAssembly} " +
                                  $"Attributes : {field.Attributes} " +
                                  $"Member Type : {field.MemberType} " +
                                  $"Declaring Type : {field.DeclaringType.Name} ");
            }
        }

        static void ConstructorCall() // Array
        {
            Type type = typeof(String);
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (var constructor in constructorInfos)
            {
                Console.WriteLine($"Name : {constructor.Name} " +
                                  $"Attributes : {constructor.Attributes} " +
                                  $"Declaring Type : {constructor.DeclaringType} " +
                                  $"Member Type : {constructor.MemberType} ");
            }
        }

        static void ParameterCall() // SysReflection.Program
        {
            Type type = typeof(String);
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var method in methodInfos)
            {
                ParameterInfo[] parameterInfo = method.GetParameters();
                foreach (var parameter in parameterInfo)
                {
                    Console.WriteLine($"{parameter.Name} " +
                                      $"{parameter.Member} " +
                                      $"{parameter.Position} " +
                                      $"{parameter.DefaultValue} " +
                                      $"{parameter.ParameterType} " +
                                      $"{parameter.IsOptional} ");
                }
            }
        }

        public static void TestMethod(int arg0, string arg1)
        {
            Type type = typeof(Program);
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var method in methodInfos)
            {
                if (method.Name == "TestMethod")
                {
                    ParameterInfo[] parameterInfos = method.GetParameters();
                    Console.Write($"{method.Name}(");
                    for(int i = 0; i<parameterInfos.Length; i++)
                    {
                        Console.Write($"{parameterInfos[i]}" + (i+1 < parameterInfos.Length ? "," : ")"));
                    }
                }
            }
        }
    }
}
