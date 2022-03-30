using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windowsform.Models.Bases;

namespace windowsform.Models
{
    internal class Daire : IDaireSekil
    {
        public double Yaricap { get ; set ; }
        public bool PiUcMu { get; set; } = true; //default değer verebiliyoruz

        public double AlanHesapla()
        {
            return PiUcMu ? 3 * Math.Pow(Yaricap, 2) : (Math.PI * Math.Pow(Yaricap, 2));
        }

        public double CevreHesapla()
        {
            return PiUcMu ? 2 * 3 * Yaricap : 2 * Math.PI * Yaricap;
            //Math.Round(Math.PI, 0);
        }
    }
}
