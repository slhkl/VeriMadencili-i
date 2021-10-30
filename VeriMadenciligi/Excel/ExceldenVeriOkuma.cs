using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel.ExcelModel;

namespace VeriMadenciligi.Excel
{
    public class ExceldenVeriOkuma
    {
        private List<ExcelData> LoadJson()
        {
            //excel dosyasındaki verileri excelToJson converter kullanarak json formatında bir txt ye dönüştürdüm
            List<ExcelData> items;
            using (StreamReader reader = new StreamReader(@"C:\Users\P2049\Desktop\ödev1\dataset_4\edu_data_json.txt"))
            {
                string json = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ExcelData>>(json);
            }
            return items;
        }
        public List<ExcelData> Veriler()
        {
            List<ExcelData> AllData = LoadJson();
            // Excelde mod 3 e tam bölünen satırları kullanmam gerekiyor ama json verisinde indexler -1 olarak geliyor ve
            // liste indexleri de 0 dan başladığı için 2 sayı kaydırıp mod 1 e göre listeyi alıyorum
            for (int i = AllData.Count-1; i >= 0; i--)
                if (i % 3 != 1)
                    AllData.RemoveAt(i);    
            return AllData;
        }
        public void Yazdir()
        {
            foreach (var item in Veriler())
            {
                Console.WriteLine($"{item.gender}, {item.NationalITy}, {item.PlaceofBirth}, {item.StageID}, {item.SectionID}, {item.Topic}, {item.Semester}, {item.Relation}, {item.raisedhands}, {item.AnnouncementsView}, {item.Discussion}, {item.ParentAnsweringSurvey}, {item.ParentschoolSatisfaction},  {item.StudentAbsenceDays}, {item.Class}\n");
            }
        }
    }
}
