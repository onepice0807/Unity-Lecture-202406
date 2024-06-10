using System;

namespace _202406101640_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 증감 연산자
            // 정수형 변수에 사용
            // ++, --
            int a = 20;
            int c = 0;

            ++a; // 전위형(전치형)
            // a = a + 1;
            Console.WriteLine($"++a = {a}");

            a++; // 후위형(후치형)
            // a = a + 1;
            Console.WriteLine($"a++ = {a}");

            c = ++a;
            // a = a + 1;
            // c = a;
            Console.WriteLine($"++a, c = {c}, a = {a}");

            c = a++;
            // a = a + 1;
            // c = a;
            Console.WriteLine($"a++, c = {c}, a = {a}");

            // --

            a--;
            // a = a - 1;

            --a;
            // a = a - 1;

            c = --a;
            // a = a - 1;
            // c = a;

            c = a--;
            // c = a;
            // a = a - 1;
        }
    }
}
