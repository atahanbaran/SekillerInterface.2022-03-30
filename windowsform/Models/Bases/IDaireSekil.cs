using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsform.Models.Bases
{
    public interface IDaireSekil:IHesapla
    {
        
        double Yaricap { get; set; }
        bool PiUcMu { get; set; }

        //double AlanHesapla(); Bu methodları yazmaya gerek yoktur IHesapladan 
        // double CevreHesapla();

    }
}
