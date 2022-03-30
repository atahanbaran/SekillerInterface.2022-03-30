using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsform.Models.Bases
{
    internal interface IKoseliSekil :IHesapla
    {
        double Genislik { get; set; }
        double Yukseklik { get; set; }

        //double AlanHesapla();
        //double CevreHesapla();
    }

}
