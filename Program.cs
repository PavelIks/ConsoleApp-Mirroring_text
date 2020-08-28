using System;

namespace MirroringText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тётя лёша не беременный!");

            var str = "Тётя лёша не беременный!";
            char[] s = str.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}