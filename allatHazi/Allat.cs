using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    abstract class Allat
    {
        public String Meret { get;}
        public String Szin { get;}
        public int LabakSzama { get;}
        public Boolean TudRepulni { get; }
        public Boolean TudUszni { get;}
        public abstract String Hang { get; }

        public Allat(String meret,String szin, int labakSzama,Boolean tudRepulni,Boolean tudUszni)
        {
            this.Meret = meret;
            this.Szin = szin;
            this.LabakSzama = labakSzama;
            this.TudRepulni = tudRepulni;
            this.TudUszni = tudUszni;

        }

        public Allat()
        {
        }

        public override string ToString()
        {
            return "Állat méret:" + Meret + "  színe:" + Szin;
        }

    }
}
