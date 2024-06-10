using System;


namespace _20240610_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = -127;
            Console.WriteLine($"a = {a}, b = {b}");

            short c = -32768;
            ushort d = 65535;
            Console.WriteLine($"c = {c}, d = {d}");

            int e = -2147483648;
            uint f = 4294967295;
            Console.WriteLine($"e = {e}, f = {e}");

            long g = -922_337_203_685_477_508;
            ulong h = 18_446_744_073_709_551_615;
            Console.WriteLine($"g = {g}, h = {h}");

            char i = '코';
            Console.WriteLine($"i = {i}끼리");

            float j = -3.4e38f;
            double k = -1.79e308;
            decimal l = 1.0e+28m;
            Console.WriteLine($"j = {j}, k = {k}, l = {l}");
            Console.WriteLine("j = {0:F38}, k = {1:F38}", j, k);

            string str = "monster";
            Console.WriteLine($"str = {str}");

            bool logicVlaue = true;
            Console.WriteLine($"logicVlaue = {logicVlaue}");

            logicVlaue = false;
            Console.WriteLine($"logicVlaue = {logicVlaue}");

        }
    }
}
