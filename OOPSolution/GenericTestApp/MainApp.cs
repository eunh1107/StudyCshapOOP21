using System;
using System.Security.Cryptography;

namespace GenericTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //int배열을 int배열로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5짜리 int 배열
            //{0, 0, 0, 0, 0,}
            //복사전
            Console.WriteLine("복사전 targetInt값 ====> ");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceInt, targetInt);
            Console.WriteLine("복사후 targetInt값 ====> ");                
            foreach(var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            float[] sourceFloat = { 1.2f, 2.3f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];
            //복사전
            Console.WriteLine("복사전 targetFloat값 ====> ");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceFloat, targetFloat);
            Console.WriteLine("복사후 targetFloat값 ====> ");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length];
            //복사전
            Console.WriteLine("복사전 targetString값 ====> ");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceString, targetString);
            Console.WriteLine("복사후 targetString값 ====> ");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray(string[] source, string[] target)
        {
            try
            {
                for (int i = 0; i < source.Length; i++)
                {
                    target[i] = source[i];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
            
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
