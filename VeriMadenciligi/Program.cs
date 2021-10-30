using System;
using System.Collections.Generic;
using VeriMadenciligi.Excel;
using VeriMadenciligi.Excel.ExcelModel;
using VeriMadenciligi.Excel.ExcelModelDto;
using VeriMadenciligi.Step2;
using VeriMadenciligi.Step3;
using VeriMadenciligi.Step4;

namespace VeriMadenciligi
{
    class Program
    {
        static void Main(string[] args)
        {
            EntropiCalculator entropicalculator = new EntropiCalculator();
            var EntropiCalculator = entropicalculator.Entropi();

            List<ExcelModelDto> Dto = new List<ExcelModelDto>();
            CleanUpData cleanUpData = new CleanUpData();
            var temp = cleanUpData.CleanUpDataWorker();
            foreach (var item in temp)
            {
                Dto.Add(new ExcelModelDto { AnnouncementsView = item.AnnouncementsView, Discussion = item.Discussion, raisedhands = item.raisedhands, Class = item.Class });
            }

            ExceleVeriYazma exceleVeriYazma = new ExceleVeriYazma();
            exceleVeriYazma.ConvertJson(Dto, "sayisal tipte veriler");
        }
    }
}
