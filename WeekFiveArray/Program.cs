using System;
using System.Linq;
//10 adet tam sayısı verisi al.
// bunu küme gibi düşün bu kümeyi foreach ile yazdır.
// bu kümeye kullanıcıdan alınan yeni bir veri ekle.
// bu kümeyi büyükten küçüğe sırala ve yazdır.

class Program
{
    static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] sayilar = new int[10];

        // 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            // eğer kullanıcıdan aldığım sayı bir sayı değilse hata verir.
             while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
    {
        Console.Write("Geçerli bir sayı girin: ");
    }
        }

        Console.WriteLine("\nGirilen sayılar:");
        
        {
            //dagha düzgün gözüksün diye
            
            Console.WriteLine(string.Join(", ", sayilar));
            Console.ReadKey();
        }

        // 3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.Write("\nYeni bir sayı girin (11. eleman olarak): ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        int[] yeniSayilar = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniSayilar[i] = sayilar[i];
        }
        yeniSayilar[yeniSayilar.Length - 1] = yeniSayi;

        // 4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(yeniSayilar);
        Array.Reverse(yeniSayilar);

        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        //daha düzgün gözüksün diye
        
        {
            Console.WriteLine(string.Join(", ", yeniSayilar));
            Console.ReadKey();
        }

        Console.ReadKey();
    }
}
