using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JenericAndEventAndDelegate
{
   public class Opel : IAraclar
    {
        string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        string plaka;
        public string Plaka
        {
            get
            {
                return plaka;
            }
            set
            {
                plaka = value;
            }
        }
        string renk;
        public string Renk
        {
            get
            {
                return renk;
            }
            set
            {
                renk = value;
            }
        }
        bool kiradurum;
        public bool KiraDurum
        {
            get
            {
                return kiradurum;
            }
            set
            {
                kiradurum = value;
            }
        }
        int kirasay;
        public int KiraSay
        {
            get
            {
                return kirasay;
            }
            set
            {
                kirasay = value;
            }
        }
    }
}
