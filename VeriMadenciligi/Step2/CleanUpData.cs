using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel.ExcelModel;
using VeriMadenciligi.Step1;

namespace VeriMadenciligi.Step2
{
    public class CleanUpData
    {
        public List<ExcelData> CleanUpDataWorker()
        {
            SayisalTipteKolon sayisalTipteKolon = new SayisalTipteKolon();
            List<ExcelData> Veriler = sayisalTipteKolon.SayisalTipteKolonlariDuzenleme();
            List<string> Degisenler = new List<string>();

            for (int i = 0; i < Veriler.Count; i++)
            {
                if(Veriler[i].NationalITy != "KW" && Veriler[i].NationalITy != "Jordan" && Veriler[i].NationalITy != "Iraq" && Veriler[i].NationalITy != "lebanon" && Veriler[i].NationalITy != "Palestine" )
                {
                    Degisenler.Add($"NationalITy kolonunda değiştirilen verinin indexi {i + 1}, değiştirilen veri {Veriler[i].NationalITy}, kaybolan verinin yerine en çok olan veri:KW yazıldı.");
                    Veriler[i].NationalITy = "KW";
                }
                if (Veriler[i].PlaceofBirth != "KuwaIT" && Veriler[i].PlaceofBirth != "Jordan" && Veriler[i].PlaceofBirth != "Iraq" && Veriler[i].PlaceofBirth != "lebanon" && Veriler[i].PlaceofBirth != "USA")
                {
                    Degisenler.Add($"PlaceofBirth kolonunda değiştirilen verinin indexi {i + 1}, değiştirilen veri {Veriler[i].PlaceofBirth}, kaybolan verinin yerine en çok olan veri:KuwaIT yazıldı.");
                    Veriler[i].NationalITy = "KuwaIT";
                }
            }
            Console.WriteLine("------------------------Step2------------------------");
            foreach (var item in Degisenler)
            {
                Console.WriteLine(item);
            }
            return Veriler;
        }
    }
}
