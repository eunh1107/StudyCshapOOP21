using Microsoft.VisualBasic;
using System;
using System.Threading.Channels;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSometing(string name);
        delegate string concatenate(string[]arr);
        static void Main(string[] args)
        {
            DoSometing doIt = (name) =>
            { 
                Console.WriteLine("Hello, ");
                Console.WriteLine($"{name}~!");
                //return; //void는 return이 있지만 return값이 없어서 생략가능
            };
        string name =  "Hugo";

            doIt(name);

            concatenate concat = arr =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };
            string[] atrarr = { "아버지가 ", "방에 ", "들어가신다." };
            Console.WriteLine(concat(atrarr));
            
            Func<int> func1=() => 3;

            var val = func1();
            Console.WriteLine($"val의 값은 {val}.");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3+5= {plus(3, 5)}");

            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };
            area(10);
        }
    }
}
