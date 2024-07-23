using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsItPassed(80))
            {
                Console.WriteLine("geçti");
            }
            else
            {
                Console.WriteLine("kaldı"); sssssss
            }


        }

        public static bool IsItPassed(int a)
        {
            var result = false;
            if (a >= 80)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }//öğrenci geçip gemdiği, int puan, 80, console geçti ksadı
    }
}