using System;
using System.Collections.Generic;

namespace GenericMyListApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<int> intList= new MyList<int>();
            for (int i = 0; i < intList.Length; i++)
            {
                intList[i] = 100;
            }
            for (int i = 0; i < intList.Length; i++)
            {              
                Console.Write($"{intList[i]}\t");
            }

            MyList<string> strList = new MyList<string>();
            for (int i = 0; i < strList.Length; i++)
            {
                strList[i] = "Hello_" + (i + 1);
            }

            for (int i = 0; i < strList.Length; i++)
            {
                Console.Write($"{strList[i]}\t");
            }
            MyList<object> objList = new MyList<object>();
            objList[0] = 111;
            objList[1] = 3.141592f;
            objList[2] = "Hello, world";

        }
    }
}
