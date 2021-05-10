using System;

namespace Test03
{
    class MainApp3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) //안쪽에 있는 for문만 건들이기 위해 if문 작성  
            {
                if (i == 5) Console.WriteLine(); //i가 5개 찍으면 한 줄 띄기

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}