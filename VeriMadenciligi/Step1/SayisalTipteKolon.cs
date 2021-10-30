using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel;
using VeriMadenciligi.Excel.ExcelModel;

namespace VeriMadenciligi.Step1
{
    public class SayisalTipteKolon
    {
        public List<ExcelData> SayisalTipteKolonlariDuzenleme()
        {
            ExceldenVeriOkuma exceldenVeriOkuma = new ExceldenVeriOkuma();
            List<ExcelData> veriler = exceldenVeriOkuma.Veriler();

            int[] raisedHands = new int[veriler.Count];
            int[] AnnouncementsView = new int[veriler.Count];
            int[] Discussion = new int[veriler.Count];

            for (int i = 0; i < veriler.Count; i++)
            {
                raisedHands[i] = veriler[i].raisedhands;
                AnnouncementsView[i] = veriler[i].AnnouncementsView;
                Discussion[i] = veriler[i].Discussion;
            }


            List<string> Degisenler = new List<string>();

            StandartSapmaVeOrtalama standartSapmaVeOrtalama = new StandartSapmaVeOrtalama();

            int raisedHandsOrt = standartSapmaVeOrtalama.OrtalamaHesaplama(raisedHands);
            double raisedHandsSp = standartSapmaVeOrtalama.StandartSapmaHesaplama(raisedHands);
            
            int AnnouncementsViewOrt = standartSapmaVeOrtalama.OrtalamaHesaplama(AnnouncementsView);
            double AnnouncementsViewSp = standartSapmaVeOrtalama.StandartSapmaHesaplama(AnnouncementsView);

            int DiscussionOrt = standartSapmaVeOrtalama.OrtalamaHesaplama(Discussion);
            double DiscussionSp = standartSapmaVeOrtalama.StandartSapmaHesaplama(Discussion);

            for (int i = 0; i < raisedHands.Length; i++)
            {
                if (raisedHands[i] > 2 * raisedHandsSp + raisedHandsOrt)
                {
                    Degisenler.Add($"raisedHands kolonunda kaybedilen verinin indexi {i+1}, kaybolan veri {raisedHands[i]}, kaybolan verinin yerine ortalama:{raisedHandsOrt} yazıldı.");
                    raisedHands[i] = raisedHandsOrt;
                    veriler[i].raisedhands = raisedHandsOrt;
                }
                if (AnnouncementsView[i] > 2 * AnnouncementsViewSp+ AnnouncementsViewOrt)
                {
                    Degisenler.Add($"AnnouncementsView kolonunda kaybedilen verinin indexi {i+1}, kaybolan veri {AnnouncementsView[i]}, kaybolan verinin yerine ortalama:{AnnouncementsViewOrt} yazıldı.");
                    AnnouncementsView[i] = AnnouncementsViewOrt;
                    veriler[i].AnnouncementsView = AnnouncementsViewOrt;
                }
                if (Discussion[i] > 2 * DiscussionSp+ DiscussionOrt)
                {
                    Degisenler.Add($"Discussion kolonunda kaybedilen verinin indexi {i+1}, kaybolan veri {Discussion[i]}, kaybolan verinin yerine ortalama:{DiscussionOrt} yazıldı.");
                    Discussion[i] = DiscussionOrt;
                    veriler[i].Discussion = DiscussionOrt;
                }
            }
            Console.WriteLine("------------------------Step1------------------------");
            foreach (var item in Degisenler)
            {
                Console.WriteLine(item);
            }
            return veriler;
        }
    }
}
