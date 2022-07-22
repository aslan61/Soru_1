using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru1: Kullanıcının girdiği sayının %18 ini bulup yazdıran basit C# Console örneği.
            double sonuç = 0;
            Console.WriteLine("Yüzdesi Alınacak Sayı: ");
            double sayı = Convert.ToInt16(Console.ReadLine());
            sonuç=sayı*(0.18);
            Console.WriteLine("Sayının Yüzde onsekizi: {0}",sonuç);
        }
    }
}
