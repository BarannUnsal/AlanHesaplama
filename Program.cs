resart:
try
{
start:
    double pi = 3.14;
    Console.WriteLine("Alan hesaplamak istediğiniz geometrik şekli seçiniz: ");
    Console.WriteLine("1 - Kare");
    Console.WriteLine("2 - Üçgen");
    Console.WriteLine("3 - Daire");
    Console.WriteLine("4 - Dikdörtgen");
    int secim = Convert.ToInt32(Console.ReadLine());
    if (secim <= 4)
    {
        switch (secim)
        {
            case 1:
                Console.WriteLine("Kare alanı için kenar uzunluğu giriniz: ");
                int kareKenar = Convert.ToInt32(Console.ReadLine());
                int sonuc = KareAlan(kareKenar);
                Console.WriteLine("Karenin alanı: " + sonuc);
                Console.WriteLine("Tekar denemek için (1)\nÇıkış için(2)");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                    goto start;
                else if (secim1 == 2)
                    Console.WriteLine("Çıkış yapılıyor!!");
                else
                    Console.WriteLine("Hatalı seçim");
                break;
            case 2:
                Console.WriteLine("Üçgen alanı için taban uzunluğu giriniz: ");
                int taban = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Üçgen alanı için uzunluğu giriniz: ");
                int uzunluk = Convert.ToInt32(Console.ReadLine());
                int sonuc1 = UcgenAlan(taban, uzunluk);
                Console.WriteLine("Üçgenin alanı: " + sonuc1);
                Console.WriteLine("Tekar denemek için (1)\nÇıkış için(2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 1)
                    goto start;
                else if (secim2 == 2)
                    Console.WriteLine("Çıkış yapılıyor!!");
                else
                    Console.WriteLine("Hatalı seçim");

                break;
            case 3:
                Console.WriteLine("Dairenin yarı çapını giriniz: ");
                double yari = Convert.ToDouble(Console.ReadLine());
                double cevre = DaireCevre(yari);
                double alan = DaireAlan(yari);
                Console.WriteLine($"Dairenin çevresi: {cevre}\nDairenin alanı: {alan}");
                Console.WriteLine("Tekar denemek için (1)\nÇıkış için(2)");
                int secim3 = Convert.ToInt32(Console.ReadLine());
                if (secim3 == 1)
                    goto start;
                else if (secim3 == 2)
                    Console.WriteLine("Çıkış yapılıyor!!");
                else
                    Console.WriteLine("Hatalı seçim");
                break;
            case 4:
                Console.WriteLine("Dikdörtgenin uzun kenar uzunğuluğunu giriniz: ");
                int uzunKenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin kısa kenar uzunluğunu giriniz: ");
                int kisaKenar = Convert.ToInt32(Console.ReadLine());
                int result = DikdörtgenAlan(kisaKenar, uzunKenar);
                Console.WriteLine($"Dikdörtgein alanı: {result}");
                Console.WriteLine("Tekar denemek için (1)\nÇıkış için(2)");
                int secim4 = Convert.ToInt32(Console.ReadLine());
                if (secim4 == 1)
                    goto start;
                else if (secim4 == 2)
                    Console.WriteLine("Çıkış yapılıyor!!");
                else
                    Console.WriteLine("Hatalı seçim");
                break;
        }
    }
    else
    {
        Console.WriteLine("Hatalı seçim!! \nÇıkış için (n) Tekrar Denemek İçin (y)");
        try
        {
            string son = Console.ReadLine();
            if (son.ToLower() == "n")
                Console.WriteLine("Görüşmek üzere");
            else if (son.ToLower() == "y")
                goto start;
            else
                Console.WriteLine("Görüşmek üzere");
        }
        catch
        {
            Console.WriteLine("Hatalı Seçim!!!");
            throw;
        }
    }
}
catch
{
    Console.WriteLine("Hata!!!");
    goto resart;
}

static int KareAlan(int kareKenar)
{
    kareKenar *= 2;
    return kareKenar;
}

static int UcgenAlan(int taban, int uzunluk)
{
    int result = taban * uzunluk / 2;
    return result;
}

static double DaireCevre(double yari)
{
    double pi = 3.14;
    double result = 2 * pi * yari;
    return result;
}
static double DaireAlan(double yari)
{
    double pi = 3.14;
    double result = pi * yari * yari;
    return result;
}

static int DikdörtgenAlan(int uzunKenar, int kisaKenar)
{
    int result = kisaKenar * uzunKenar;
    return result;
}