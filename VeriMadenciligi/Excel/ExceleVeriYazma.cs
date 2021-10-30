using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriMadenciligi.Excel
{
    public class ExceleVeriYazma
    {
        public void ConvertJson<T>(List<T> veriler, string fileName)
        {
            string Jsonveri = JsonConvert.SerializeObject(veriler);

            File.WriteAllText(@"C:\Users\P2049\Desktop\ödev1\dataset_4\" + fileName + ".txt", Jsonveri);
        }
    }
}
