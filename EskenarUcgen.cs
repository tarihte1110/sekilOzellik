using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp5 
{
    public class EskenarUcgen:Sekiller
    {
        private int kenar;

        public EskenarUcgen() { }

        public EskenarUcgen(int kenar)
        {
            this.kenar = kenar;
        }
        public double AlanHesapla()
        {
            double alan= (Math.Sqrt(3) / 4) * Math.Pow(kenar, 2);
            return alan;
        }
        public double CevreHesapla()
        {
            double cevre = 3 * kenar;
            return cevre;
        }
        public void setKenar(int kenar)
        {
            this.kenar = kenar;
        }
        public int getKenar()
        {
            return kenar;
        }

        public void Ciz()
        {
            char sembol = getSembol();

            for (int i = 0; i < kenar; i++)
            {
                for (int j = 0; j < kenar - i - 1; j++)
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
            string ozellik = $"{getOlusturulmaTarihi()} tarihinde oluşturulan Eşkenar Üçgen sınıfı ==> Kenar={kenar},  Alan={AlanHesapla()}, Cevre={CevreHesapla()}";
            return ozellik;
        }
    }
}
