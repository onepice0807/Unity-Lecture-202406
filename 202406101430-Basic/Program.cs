using System;

namespace _20240610_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("monster"); //줄바꿈을 하지 않는다 
            Console.WriteLine("is a World!");  // 줄바꿈을 한다.

            Console.WriteLine(string.Format("bool\t size: {0} byte", sizeof(bool)));
            Console.WriteLine("char\t size: {0} byte", sizeof(char));
            Console.WriteLine("sbyte\t size: " + sizeof(sbyte) + "byte");
            Console.WriteLine($"short\t size: {sizeof(byte)} byte");
            Console.WriteLine($"ushort\t size: {sizeof(ushort)} byte");
            Console.WriteLine($"int\t size: {sizeof(int)} byte");
            Console.WriteLine($"uint\t size: {sizeof(uint)} byte");
            Console.WriteLine($"long\t size: {sizeof(long)} byte");
            Console.WriteLine($"ulong\t size: {sizeof(ulong)} byte");

            Console.WriteLine($"float\t size: {sizeof(float)} byte");
            Console.WriteLine($"double\t size: {sizeof(double)} byte");
            Console.WriteLine($"decimal\t size: {sizeof(decimal)} byte");
        }
    }
}
