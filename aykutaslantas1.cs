using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aykutaslantas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("1. Sayıyı Giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayyıyı Giriniz :");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.Write("Sayıların Toplamı ={0}",toplam);
            Console.ReadKey();//aykutaslantass
        }
    }
}
