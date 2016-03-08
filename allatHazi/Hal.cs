using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Hal:Allat
    {
        public Boolean EdesVizi { get;}

        public override string Hang
        {
            get
            {
                return "<tatogas>";
            }
        }

        public Hal(String meret, String szin, Boolean tudRepulni, int labakSzama, Boolean tudUszni, Boolean edesvizi)
            : base(meret, szin, labakSzama, tudRepulni, tudUszni)
        {
            this.EdesVizi = edesvizi;
            
        }

        public override string ToString()
        {
            return "Állat mérete:" + Meret + "  édes vízi-e?:" + EdesVizi ;
        }
    }
}
