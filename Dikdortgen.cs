using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp5
{
    public class Dikdortgen:Sekiller
    {
        private int genislik;
        private int yukseklik;

        public Dikdortgen() { }

        public Dikdortgen(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }   
        public  double AlanHesapla()
        {
            return genislik * yukseklik;
        }
        public double CevreHesapla()
        {
            return 2*(genislik+yukseklik);
        }
        public void setGenislik(int genislik)
        {
            this.genislik = genislik;
        }
        public int getGenislik()
        {
            return genislik;
        }
        public void setYukseklik(int yukseklik)
        {
            this.yukseklik=yukseklik;
        }
        public int getYukseklik()
        {
            return yukseklik;
        }

        public void Ciz()
        {
            char sembol = getSembol();

            if (getDoluMu())
            {
                for (int i = 0; i < yukseklik; i++)
                {
                    for (int j = 0; j < genislik; j++)
                    {
                        Console.Write(sembol);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < yukseklik; i++)
                {
                    for (int j = 0; j < genislik; j++)
                    {
                        if (i == 0 || i == yukseklik - 1 || j == 0 || j == genislik - 1)
                        {
                            Console.Write(sembol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public string OzellikYazdir()
        {
            string ozellik = $"{getOlusturulmaTarihi()} tarihinde oluşturulan Dikdörtgen sınıfı ==> Genişlik={genislik}, Yükseklik={yukseklik}, Alan={AlanHesapla()}, Çevre={CevreHesapla()}";
            return ozellik;
        }
    }
}
