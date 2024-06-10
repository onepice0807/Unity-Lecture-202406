using System;

namespace _202406101650_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("할당연산자 = ");
            int a = 20;
            int b = 30;
            float c = 1.2f;

            a = b;

            // C#은 DataType의 처리가 엄격하다.
            // 다른 타입간에는 명시적으로 형변환을 해야한다.
            a = (int)c; // 실수형 변수의 값을 정수형 변수에 할당할때는 형변환을 해야한다.

            c = a; // 정수형 변수를 실수형 변수에 대입할때는 형변환을 하지 않아도 된다.

            // 할당 연산자는 축약형이 가능하다.
            a += 1;
            // a = a + 1;

            a -= b;
            // a = a - b;
        }
    }
}
