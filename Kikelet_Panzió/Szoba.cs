using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kikelet_Panzió
{
    internal class Szoba
    {
        int szobaszam { get; }
        int ferohelyek { get; set; }
        int ar { get; set; }

        public Szoba(int szobaszam, int ferohelyek, int ar)
        {
            this.szobaszam = szobaszam;
            this.ferohelyek = ferohelyek;
            this.ar = ar;
        }


    }

}
