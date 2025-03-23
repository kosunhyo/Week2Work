using System;
using System.Diagnostics;

//Console.WriteLine("Hello, World!");

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            Calculator calculator = new Calculator();
            calculator.Awake();
        }
    }
    public class Calculator
    {
        public void Awake()
        {


            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2, 3));

            Md1("1", 2, "Null");
            Md2("2", 1);

            
            /*Multiple(3, 4);
            Multiple(5, 8);
            Multiple(4, 6);
            int a = int.Max(10, 20);
            Console.Write(Max(100, 200));
            Max(5, 10);

            int c = 3, d = 4;
            Console.WriteLine($"c = {c}, d = {d}");
            Swap(ref c, ref d);
            Console.WriteLine($"c = {c}, d = {d}");*/

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }


        /*public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public void Add(float num1, float num2)
        {
            float result = num1 + num2;
            Console.Write($"{num1} + {num2} = {result}");
        }*/

        public void Multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} x {num2} = {result}");
        }

        public int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        public void Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.Write("나누려는 값이 0이기 때문에 프로그램 종료");
                return;
            }

            float result = num1 / num2;
            Console.Write($"{num1} / {num2} = {result}");
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"합계 : {sum}");
        }
        public void Md1(string str1, int num1, string str2)
        {
            Console.WriteLine(str1 + num1 + str2);
        }
        public void Md2(string str1, int num1 = 0, string str2 = "null")
        {
            Console.WriteLine(str1 + num1 + str2);
        }
    }
    
}