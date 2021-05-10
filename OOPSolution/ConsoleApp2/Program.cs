using System;

namespace Test05
{
    class MainApp5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0) Console.WriteLine(); //i값을 나머지 15로 나눴을 때 값이 0이면 한줄 밑으로 내리기

                if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9 || //3, 6, 9 등 3의 배수 짝을 하기 위해
                    i / 10 == 3 || i / 10 == 6 || i / 10 == 9)  //3~, 6~, 9~ 등 또한 짝을 하기 위해
                    Console.Write("짝!\t");
                else if (i == 0) //0일때도 짝을 하기 위해
                    Console.Write("짝!\t");
                else
                    Console.Write($"{i}\t");
            }
        }
    }
}
