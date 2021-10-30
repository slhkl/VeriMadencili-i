using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel;
using VeriMadenciligi.Excel.ExcelModel;
using VeriMadenciligi.Step1;

namespace VeriMadenciligi.Step2
{
    public class Histogram
    {
        public void HistogramHesap()
        {
            SayisalTipteKolon sayisalTipteKolon = new SayisalTipteKolon();
            List<ExcelData> Veriler = sayisalTipteKolon.SayisalTipteKolonlariDuzenleme();

            ExceleVeriYazma exceleVeriYazma = new ExceleVeriYazma();
            exceleVeriYazma.ConvertJson(Veriler, "JsonForHistogram");

            // verileri dışarı aktarıp JsonToExcel convertor kullanarak excele çevirdim
            // Excel kolonlarını histogramlaştırdım.
        }
    }
}
