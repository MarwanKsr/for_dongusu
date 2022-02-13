using System;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("faktoriyeli hesaplamak istedigin sayiyi giriniz: ");
            int fak = 1;
            int sayi = int.Parse(Console.ReadLine());
            for (int i=1; i<=sayi; i++)
            {
                fak *= i;
            }
            Console.WriteLine(fak);
        }

    }
    
}