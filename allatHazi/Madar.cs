using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Madar:Allat
    {
        public Boolean Ragadozo { get;}
        public Boolean KalitkabanTarhato { get; }

        public override string Hang
        {
            get
            {
                return "<csipogas>";
            }
        }

        public Madar(String meret, String szin, Boolean tudRepulni, int labakSzama, Boolean tudUszni, Boolean ragadozo,Boolean kalitkabanTarthato)
            : base(meret, szin, labakSzama, tudRepulni, tudUszni)
        {
            this.Ragadozo = ragadozo;
            this.KalitkabanTarhato = kalitkabanTarthato;
            
        }

        public override string ToString()
        {
            return "Állat mérete:" + Meret + " színe:" + Szin + "  tud repülni?:" + TudRepulni + "  tartható kalitkában?:" + KalitkabanTarhato;
        }
    }
}
