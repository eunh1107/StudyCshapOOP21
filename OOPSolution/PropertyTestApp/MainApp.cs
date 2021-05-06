﻿using System;
using System.Net.Cache;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog baekgoo = new Dog();
            //baekgoo.SetAge(5); //5살
            baekgoo.Name = "백구";

            //Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()}살");
            baekgoo.Age = 25000;
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}세");

            Dog StreetDog = new Dog();
            Console.Write($"{StreetDog.Name}는 {StreetDog.Color}색입니다.");

            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Color = "노랑";
            dog1.Age = 10;

            Dog dog2 = new ()
            {
                Name = "깜장이",
                Age = 5,
                Color = "검정",
              };

            var myInstance = new { Name = "성명건", Age = 44 };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);
            }
        }
    }

