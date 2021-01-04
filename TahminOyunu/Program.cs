using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 3'e Kadar bir seviye seçiniz:");
            int seviye = int.Parse(Console.ReadLine());
            int hak1 = 6;
            int hak2 = 4;
            int hak3 = 2;
            Random rnd1 = new Random();
            int sayı1 = rnd1.Next(1, 10);
            Random rnd2 = new Random();
            int sayı2 = rnd2.Next(1, 25);
            Random rnd3 = new Random();
            int sayı3 = rnd3.Next(1, 50);
            for (;;)
            {
                if (seviye == 1)
                {
                    Console.WriteLine(hak1+"hakkınız kaldı");
                    hak1--;
                    if (hak1<0)
                    {
                        Console.WriteLine("Kaybettiniz doğru sayı"+" "+sayı1);
                        break;
                    }
                    Console.WriteLine("Tahmin yapınız");
                    int tahmin = int.Parse(Console.ReadLine());
                    if(tahmin==sayı1)
                    {
                        Console.WriteLine("Tebrikler oyunu kazandınız.");
                    }
                }
                else if (seviye == 2)
                {
                    Console.WriteLine(hak2 + "hakkınız kaldı");
                    hak2--;
                    if(hak2<0)
                    {
                        Console.WriteLine("Kaybettiniz doğru sayı"+" "+sayı2);
                        break;
                    }
                    Console.WriteLine("Tahmin yapınız");
                    int tahmin = int.Parse(Console.ReadLine());
                    if(tahmin==sayı2)
                    {
                        Console.WriteLine("Tebrikler oyunu kazandınız.");
                    }
                }
                else if (seviye == 3)
                {
                    Console.WriteLine(hak3+"hakkınız kaldı");
                    hak3--;
                    if(hak3<0)
                    {
                        Console.WriteLine("Kaybettiniz doğru sayı"+" "+sayı3);
                        break;
                    }
                    Console.WriteLine("Tahmin yapınız");
                    int tahmin = int.Parse(Console.ReadLine());
                    if(tahmin==sayı3)
                    {
                        Console.WriteLine("Tebrikler oyunu kzandınız");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
