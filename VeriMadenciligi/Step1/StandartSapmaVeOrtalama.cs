using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriMadenciligi.Step1
{
    public class StandartSapmaVeOrtalama
    {
        public int OrtalamaHesaplama(int[] dizi) // Ortalama
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
                toplam += dizi[i];

            return toplam / dizi.Length;
        }
        public double StandartSapmaHesaplama(int[] dizi) // Standart Sapma
        {
            int ort = OrtalamaHesaplama(dizi);
            double toplam = 0.0;
            for (int i = 0; i < dizi.Length; i++)
                toplam += Math.Pow((dizi[i] - ort), 2);
            return Math.Sqrt(toplam / (dizi.Length - 1));
        }
    }
}
