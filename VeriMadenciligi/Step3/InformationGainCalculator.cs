using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel.ExcelModel;
using VeriMadenciligi.Step2;
using VeriMadenciligi.Step4;

namespace VeriMadenciligi.Step3
{
    public class InformationGainCalculator
    {
        public List<List<List<int>>> InformationGainCalculated()
        {
            CleanUpData cleanUpData = new CleanUpData();
            List<ExcelData> veriler = cleanUpData.CleanUpDataWorker();

            HowManyDiffrentItem howManyDiffrentItem = new HowManyDiffrentItem();
            List<List<List<int>>> VerilerList = howManyDiffrentItem.Calculate(veriler);



            Console.WriteLine("------------------------Step3-------------------------");
            InformationGainHesapla(VerilerList[0], "gender", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[1], "nationality", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[2], "placeOfBirth", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[3], "stageId", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[4], "SectionId", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[5], "topic", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[6], "semester", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[7], "relation", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[8], "ParentAnsweringSurvey", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[9], "ParentschoolSatisfaction", VerilerList[11][0]);
            InformationGainHesapla(VerilerList[10], "StudentAbsenceDays", VerilerList[11][0]);
            
            return VerilerList;
        }
        public void InformationGainHesapla(List<List<int>> data, string colName, List<int> finalCol)
        {

            double hesap = 0;
            for (int i = 0; i < data.Count; i++)
                hesap += EntropiHesaplaForInformationGain(data[i]);

            Console.WriteLine($"{colName}InformationGain {EntropiHesaplaForInformationGain(finalCol) - hesap}");

        }
        public double EntropiHesaplaForInformationGain(List<int> data)
        {
            int MaxData = 0;
            for (int i = 0; i < data.Count; i++)
                MaxData += data[i];

            double hesap = 0;
            for (int i = 0; i < data.Count; i++)
                if (data[i] != 0)
                    hesap += (double)data[i] / MaxData * -Math.Log2((double)data[i] / MaxData);

            return hesap * MaxData / 160.0;
        }
    }
}
