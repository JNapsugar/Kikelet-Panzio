using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kikelet_Panzió
{
    public class Ugyfel
    {
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string Szuletes { get; set; }
        public string Email { get; set; }
        public string Jelszo { get; set; }
        public bool VIP { get; set; }
        public bool Visszajaro { get; set; }
        public int Fizetett { get; set; }

        public Ugyfel(string azonosito, string nev, string szuletes, string email, string jelszo, bool vIP, bool visszajaro, int fizetett)
        {
            Azonosito = azonosito;
            Nev = nev;
            Szuletes = szuletes;
            Email = email;
            Jelszo = jelszo;
            VIP = vIP;
            Visszajaro = visszajaro;
            Fizetett = fizetett;
        }

        public override string? ToString()
        {
            return $"{Azonosito} {Nev} {Szuletes} {Email} {Jelszo} {VIP}";
        }
    }
}
