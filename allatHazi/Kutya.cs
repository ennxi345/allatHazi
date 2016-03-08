using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Kutya:Allat
    {
        public Boolean Lakasban { get;}

        public override string Hang
        {
            get
            {
                return "<ugatás>";
            }
        }

        public Kutya(String meret,String szin,Boolean tudRepulni,int labakSzama,Boolean tudUszni, Boolean lakasban)
            : base(meret,szin,labakSzama,tudRepulni,tudUszni)
        {
            this.Lakasban = lakasban;
            
        }


        public override string ToString()
        {
            return "Állat méret:" + Meret + "  színe:" + Szin + "  tartható lakásban?:" + Lakasban;
        }

    }

}
