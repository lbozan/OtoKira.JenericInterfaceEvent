using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JenericAndEventAndDelegate
{
  public delegate void TakipHandler(object s, TakipEventArgs e);
  
  public class TakipEventArgs
    {
        public TakipEventArgs()   { }
        
        public TakipEventArgs(int say,string plaka, string mesaj)
        {
            this.say = say;
            this.plaka = plaka;
            this.mesaj = mesaj;
        }
        
        public int say { get; set; }
        public string plaka { get; set; }
        public string mesaj { get; set; }
    }
    
  public class Run<T> where T : IAraclar
    {
        public event TakipHandler TakipEvent;
        private void TakipOlay(int say,string plaka,string mesaj)
        {
            if (TakipEvent!=null)
            {
                TakipEvent(this, new TakipEventArgs() { say = say, plaka = plaka, mesaj = "Bir olay oluştu" });
            }
        }

        public List<T> liste { get; set; }
        public Run()
        {
            liste = new List<T>();
        }
        public void Listele()
        {
            foreach (var item in liste)
            {
                Console.WriteLine("Marka {0} Model {1} Plaka {2} Renk {3} KiraDurum {4} KiraSay {5}",item.GetType().Name,item.Model,item.Plaka,item.Renk,item.KiraDurum,item.KiraSay);
            }
        }
        public void KiraListe()
        {
           liste.Where(x => x.KiraDurum == true).ToList().ForEach(X => Console.WriteLine("{0} Plaka {1}", X.KiraDurum,X.Plaka));
        }
        public void Kirala()
        {
            Console.Write("Kiralanacak Aracın Plakasını Girin :");
            string plaka = Console.ReadLine();

            var list = liste.Where(x => x.Plaka == plaka).FirstOrDefault().KiraDurum;
            if (list ==true)
            {
                var list2 = liste.Where(x=>x.Plaka==plaka).FirstOrDefault().KiraSay;

                TakipOlay(list2,plaka,"Arac Kiralanamaz ");
            }
        }
    }
}
