using System;

namespace AttributeTestApp
{
    public class MyClass
    {
        //Properties...
        
        [Obsolete("이 메서드는 폐기되었습니다. NewMethod()로 대체하세요.")]
        public void OldMethod() { Console.WriteLine("무언가를 한다."); }
        public void NewMethod() { Console.WriteLine("새로운 무언가를 한다."); }
    
        public int Plus(int a, int b) { return a + b; }
        public int Divide(int a, int b) { return a / b; }
    }

    class Program 
    { 
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            //mine.OldMethod(); //안 쓰도록 유도
            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
