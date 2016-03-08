using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Kigyo:Allat,IComparable<Kigyo>
    {
        public Boolean Merges { get;}

        public override string Hang
        {
            get
            {
                return "<sziszeges>";
            }
        }

        public Kigyo(String meret, String szin, Boolean tudRepulni, int labakSzama,Boolean tudUszni ,Boolean merges)
            : base(meret, szin, labakSzama, tudRepulni, tudUszni)
        {
            this.Merges = merges;
            
            
        }

        
        

        public override string ToString()
        {
            return "Állat mérete:" + Meret + "  színe:" + Szin +"  mérges?:" + Merges + "  tud úszni?:" + TudUszni;
        }

        public int CompareTo(Kigyo other)
        {

            return Meret.CompareTo(other.Meret);
        }
    }
}
