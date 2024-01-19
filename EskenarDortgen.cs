using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ntp5
{
    public class EskenarDortgen:Sekiller
    {
        private int genislik;
        private int yukseklik;

        public EskenarDortgen() { }

        public EskenarDortgen(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }   
        
        public double AlanHesapla()
        {
                double alan = genislik * yukseklik;
                return alan;
        }
        public void setYukseklik(int yukseklik)
        {
            this.yukseklik = yukseklik;
        }
        public int getYukseklik()
        {
            return yukseklik;
        }
        public void setGenislik(int genislik)
        {
            this.genislik = genislik;
        }
        public int getGenislik()
        {
            return genislik;
        }

        public void Ciz()
        {
            char sembol = getSembol();

            if (yukseklik != genislik)
            {
                Console.WriteLine("Çizim yapılamıyor. Genişlik ve yükseklik eşit olmalıdır.");
                return;
            }

            int yarimYukseklik = yukseklik / 2;

            for (int i = 0; i < yarimYukseklik + 1; i++)
            {
                for (int j = 0; j < yarimYukseklik - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write(sembol);
                }

                Console.WriteLine();
            }

            for (int i = yarimYukseklik - 1; i >= 0; i--)
            {
                for (int j = 0; j < yarimYukseklik - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write(sembol);
                }

                Console.WriteLine();
            }
        }
        public string OzellikYazdir()
        {
            string ozellik = $"{getOlusturulmaTarihi()} tarihinde oluşturulan Eşkenar Dörtgen sınıfı ==> Genişlik={genislik}, Yükseklik={yukseklik}, Alan={AlanHesapla()}";
            return ozellik;
        }
    }                                                            
}
