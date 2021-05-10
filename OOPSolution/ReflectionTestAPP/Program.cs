using System;
using System.Reflection;

namespace ReflectionTestAPP
{
    class person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Printprofile() { Console.WriteLine($"{Age}, {Name}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            person a = new person();
            Type type = a.GetType(); //Int32
            Console.WriteLine("field 타입 리스트 : ");
            FieldInfo[] fields = type.GetFields();
            foreach (var item in fields)
            {
                Console.WriteLine($"Type:{item.FieldType.Name}, Name:{item.Name}");
            }

            Console.WriteLine("Property 타입 리스트 : ");
            PropertyInfo[] Properties = type.GetProperties();
            foreach (var item in Properties)
            {
                Console.WriteLine($"Type:{item.PropertyType.Name}, Name:{item.Name}");
            }

            Console.WriteLine("method 타입 리스트 : ");
            MethodInfo[] methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"Type:{item.ReturnType.Name}, Name:{item.Name}");
            }
        }
    }
}
