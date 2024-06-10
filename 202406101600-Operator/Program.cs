using System;

namespace _20240610_Operator.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 나머지 연산자(%) modulate operator
            // 나머지 연산자는 정수값에 사용할 수 있다.
            Random random = new System.Random(); // 난수 발생용 객체 생성

            for (int i = 0; i < 10; i++)
            {
                int randValue = random.Next();  // 난수 발생.


                Console.WriteLine("randValue = {0}", randValue);

                // % 나머지 연산자: 임의의 값을 의미있는 범위의 값으로 만들때 사용

                //0: 도망(runAway), 1: 공격(attack), 2: 방어(defense)

                int actionValue = randValue % 3;
                switch (actionValue)
                {
                    case 0:
                        Console.WriteLine("Run Away");
                        break;

                    case 1:
                        Console.WriteLine("Attack");
                        break;

                    case 2:
                        Console.WriteLine("Defense");
                        break;
                }

            }

        }
    }
}


