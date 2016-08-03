using System;
using System.Collections.Generic;


namespace JenericAndEventAndDelegate
{
    public interface IAraclar
    {
       string Model { get; set; }
       string Plaka { get; set; }
       string Renk { get; set; }
       bool KiraDurum { get; set; }
       int KiraSay { get; set; }
    }
}
