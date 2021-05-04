using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ExceptionServices;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //숫자 0과 알파벳 대문자 오(O)와 알파벳 소문자 오(o)
            //알파벳 대문자 아이(I)와 알파벳 소문자 엘(l)과 숫자 1
            Console.WriteLine("==============================================================================");
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat("키티", 3);
            kitty.Name = " 키티";
            kitty.Age = 3;
            kitty.Color = "하얀 ";
            kitty.Meow();

            Cat nero = new Cat(" 네로","검은 ");
            /*{
                Name = " 네로",
                Age = 12,
                Color = "검은 "
            };*/
            nero.Meow();

            Cat mimi = new Cat(" 미미", "노란 ", 3); // 추가생성자 
            mimi.Meow();

            Cat coco = new Cat(" 코코", "얼룩 ");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat(" 야옹이", "은색 ", 10);
            //noname.Name = " 야옹이";
            noname.Meow(); 
            noname.Sleep();

            var list = (First : "Cat", Second : "Dog", Third : "Pig", 55);
            Console.Write($"튜플 첫번째 : {list.First} /");
            Console.Write($" 튜플 두번째 : {list.Second} /");
            Console.Write($" 튜플 세번째 : {list.Third} /");
            Console.WriteLine($" 튜플 네번째 : {list.Item4}");

            Console.WriteLine("==============================================================================");

        }
    }
}
