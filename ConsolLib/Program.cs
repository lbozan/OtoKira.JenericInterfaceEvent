using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JenericAndEventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            AnaMenu<IAraclar> a = new AnaMenu<IAraclar>();
            a.liste.Add(new Opel { Model = "Insigna", Plaka = "21 Mx 21", Renk = "Gri", KiraDurum = true, KiraSay = 3 });
            a.liste.Add(new Renault { Model = "Reno 19", Plaka = "22 Mx 22", Renk = "Beyaz", KiraDurum = false, KiraSay = 0 });
            a.liste.Add(new Fiat { Model = "Fiat Srs", Plaka = "23 Mx 23", Renk = "Kırmızı", KiraDurum = true, KiraSay = 5 });
            a.liste.Add(new Bmw { Model = "I350", Plaka = "24 Mx 24", Renk = "Siyah", KiraDurum = false, KiraSay = 0 });
            a.TakipEvent += new TakipHandler(a_TakipEvent);
            a.Listele();
            a.KiraListe();
            a.Kirala();
            Console.ReadLine();
        }

        static void a_TakipEvent(object s, TakipEventArgs e)
        {
            Console.WriteLine("{0} - {1} {2}",e.say,e.plaka,e.mesaj);
        }

    }
}
