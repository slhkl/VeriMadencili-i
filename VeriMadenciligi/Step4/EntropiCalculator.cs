using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel.ExcelModel;
using VeriMadenciligi.Step3;

namespace VeriMadenciligi.Step4
{
    public class EntropiCalculator
    {
        public List<List<List<int>>> Entropi()
        {
            InformationGainCalculator informationGainCalculator = new InformationGainCalculator();
            List<List<List<int>>> veriler = informationGainCalculator.InformationGainCalculated();
            List<List<int>> list = HowManyItem(veriler);

            Console.WriteLine("------------------------Step4-------------------------");
            EntropiHesapla(list[0], "gender");
            EntropiHesapla(list[1], "nationality");
            EntropiHesapla(list[2], "placeOfBirth");
            EntropiHesapla(list[3], "stageId");
            EntropiHesapla(list[4], "SectionId");
            EntropiHesapla(list[5], "topic");
            EntropiHesapla(list[6], "semester");
            EntropiHesapla(list[7], "relation");
            EntropiHesapla(list[8], "ParentAnsweringSurvey");
            EntropiHesapla(list[9], "ParentschoolSatisfaction");
            EntropiHesapla(list[10], "StudentAbsenceDays");
            EntropiHesapla(list[11], "class");


            return veriler;
        }
        public void EntropiHesapla(List<int> data, string colName, int MaxData = 160)
        {
            double hesap = 0;
            for (int i = 0; i < data.Count; i++)
                hesap += (double)data[i] / MaxData * -Math.Log2((double)data[i] / MaxData);

            Console.WriteLine($"{colName}Entropi {hesap}");
        }
        public List<List<int>> HowManyItem(List<List<List<int>>> veriler)
        {
            List<int> genderEntropi = new List<int>();
            for (int i = 0; i < veriler[0].Count; i++)
            {
                genderEntropi.Add(veriler[0][i][0] + veriler[0][i][1] + veriler[0][i][2]);
            }

            List<int> nationalityEntropi = new List<int>();
            for (int i = 0; i < veriler[1].Count; i++)
            {
                nationalityEntropi.Add(veriler[1][i][0] + veriler[1][i][1] + veriler[1][i][2]);
            }

            List<int> placeOfBirthEntropi = new List<int>();
            for (int i = 0; i < veriler[2].Count; i++)
            {
                placeOfBirthEntropi.Add(veriler[2][i][0] + veriler[2][i][1] + veriler[2][i][2]);
            }

            List<int> stageIdEntropi = new List<int>();
            for (int i = 0; i < veriler[3].Count; i++)
            {
                stageIdEntropi.Add(veriler[3][i][0] + veriler[3][i][1] + veriler[3][i][2]);
            }

            List<int> SectionIdEntropi = new List<int>();
            for (int i = 0; i < veriler[4].Count; i++)
            {
                SectionIdEntropi.Add(veriler[4][i][0] + veriler[4][i][1] + veriler[4][i][2]);
            }

            List<int> topicEntropi = new List<int>();
            for (int i = 0; i < veriler[5].Count; i++)
            {
                topicEntropi.Add(veriler[5][i][0] + veriler[5][i][1] + veriler[5][i][2]);
            }

            List<int> semesterEntropi = new List<int>();
            for (int i = 0; i < veriler[6].Count; i++)
            {
                semesterEntropi.Add(veriler[6][i][0] + veriler[6][i][1] + veriler[6][i][2]);
            }

            List<int> relationEntropi = new List<int>();
            for (int i = 0; i < veriler[7].Count; i++)
            {
                relationEntropi.Add(veriler[7][i][0] + veriler[7][i][1] + veriler[7][i][2]);
            }
            List<int> ParentAnsweringSurveyEntropi = new List<int>();
            for (int i = 0; i < veriler[8].Count; i++)
            {
                ParentAnsweringSurveyEntropi.Add(veriler[8][i][0] + veriler[8][i][1] + veriler[8][i][2]);
            }

            List<int> ParentschoolSatisfactionEntropi = new List<int>();
            for (int i = 0; i < veriler[9].Count; i++)
            {
                ParentschoolSatisfactionEntropi.Add(veriler[9][i][0] + veriler[9][i][1] + veriler[9][i][2]);
            }

            List<int> StudentAbsenceDaysEntropi = new List<int>();
            for (int i = 0; i < veriler[10].Count; i++)
            {
                StudentAbsenceDaysEntropi.Add(veriler[10][i][0] + veriler[10][i][1] + veriler[10][i][2]);
            }

            List<int> classEntropi = new List<int>();
            for (int i = 0; i < veriler[11][0].Count; i++)
            {
                classEntropi.Add(veriler[11][0][i]);
            }

            List<List<int>> AllList = new List<List<int>>() {genderEntropi, nationalityEntropi, placeOfBirthEntropi, stageIdEntropi, SectionIdEntropi, topicEntropi, semesterEntropi, relationEntropi, ParentAnsweringSurveyEntropi, ParentschoolSatisfactionEntropi, StudentAbsenceDaysEntropi, classEntropi };
            return AllList;
        }
    }
}
