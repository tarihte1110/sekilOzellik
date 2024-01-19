using System.Globalization;

namespace ntp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1-) Dikdörtgen\n2-) Eşkenar Üçgen\n3-) Eşkenar Dörtgen\n4-) Çıkış \n \nSEÇİMİNİZ: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            bool cikis = false;
           
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Dikdörtgenin genişliğini giriniz :");
                        int genislik = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dikdörtgenin yüksekliğini giriniz:");
                        int yukseklik = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Dikdortgen dikdortgen = new Dikdortgen();
                        dikdortgen.setGenislik(genislik);
                        dikdortgen.setYukseklik(yukseklik);
                        dikdortgen.setSembol('x');
                        dikdortgen.setDoluMu(false);
                        Console.WriteLine("Alanı:" + dikdortgen.AlanHesapla());
                        Console.WriteLine();
                        Console.WriteLine("Çevresi:" + dikdortgen.CevreHesapla());
                        Console.WriteLine();
                        Console.WriteLine("Özellikleri:" + dikdortgen.OzellikYazdir());
                        Console.WriteLine();
                        dikdortgen.Ciz();
                        Console.WriteLine();


                        break;
                    case 2:
                        Console.WriteLine("Eşkenar üçgenin kenar uzunluğunu giriniz:");
                        int kenar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        EskenarUcgen eskenarUcgen = new EskenarUcgen();
                        eskenarUcgen.setKenar(kenar);
                        eskenarUcgen.setSembol('#');
                        Console.WriteLine("Alanı:" + eskenarUcgen.AlanHesapla());
                        Console.WriteLine();
                        Console.WriteLine("Çevresi:" + eskenarUcgen.CevreHesapla());
                        Console.WriteLine();
                        Console.WriteLine("Özellikleri:" + eskenarUcgen.OzellikYazdir());
                        Console.WriteLine();
                        eskenarUcgen.Ciz();
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.WriteLine("Eşkenar dörtgenin genişliğini giriniz :");
                        int genislik1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Eşkenar dörtgenin yüksekliğini giriniz:");
                        int yukseklik1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        EskenarDortgen eskenarDortgen = new EskenarDortgen();
                        eskenarDortgen.setGenislik(genislik1);
                        eskenarDortgen.setYukseklik(yukseklik1);
                        eskenarDortgen.setSembol('o');
                        if (yukseklik1 == genislik1)
                        {
                            Console.WriteLine("Alanı:" + eskenarDortgen.AlanHesapla());
                        }
                        else { Console.WriteLine("Eşkenar dörtgende genişlik ve yükseklik değerleri birbirine eşit olmalıdır"); }
                        Console.WriteLine();
                        Console.WriteLine("Özellikleri:" + eskenarDortgen.OzellikYazdir());
                        Console.WriteLine();
                        eskenarDortgen.Ciz();
                        Console.WriteLine();

                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        cikis = true;
                        Environment.Exit(1110);

                        break;

                    default:
                        Console.WriteLine("Hatalı giriş yaptınız");
                        break;
                }
            } while (true);
           
        }
    }
}