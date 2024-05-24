using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kikelet_Panzió
{
    public class Szoba
    {
        public string Szobaszam { get; }
        public int Ferohelyek { get; set; }
        public int Ar { get; set; }
        public bool Foglalt { get; set; }
        public string Mettol { get; set; }
        public string Meddig { get; set; }

        public Szoba(string szobaszam, int ferohelyek, int ar, bool foglalt, string mettol, string meddig)
        {
            this.Szobaszam = szobaszam;
            this.Ferohelyek = ferohelyek;
            this.Ar = ar;
            this.Foglalt = foglalt;
            this.Mettol = mettol;
            this.Meddig = meddig;
        }

    }

}
