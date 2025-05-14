using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 öğrenci, 4 ders için notlar [öğrenci, ders]
            int[,] notlar = {
            { 80, 90, 70, 60 },
            { 75, 85, 95, 88 },
            { 60, 65, 70, 75 }
        };

            int ogrenciSayisi = notlar.GetLength(0);
            int dersSayisi = notlar.GetLength(1);

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                int toplam = 0;
                for (int j = 0; j < dersSayisi; j++)
                {
                    toplam += notlar[i, j];
                }
                double ortalama = (double)toplam / dersSayisi;
                Console.WriteLine($"{i + 1}. Öğrencinin Ortalaması: {ortalama:F2}");
            }

            Console.WriteLine("\nTüm notları tablo halinde gösterelim:");
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"Öğrenci {i + 1}: ");
                for (int j = 0; j < dersSayisi; j++)
                {
                    Console.Write($"{notlar[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
