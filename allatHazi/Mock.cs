using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Mock
    {
        Random rand = new Random();
        String defaultSzin = "barna";

        //Random logikai típusra
        public Boolean boolRandomize()
        {
            int szam = rand.Next(2);
            if(szam == 0)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }

        public String Szinez()
        {
            String[] szinek = { "barna", "fekete", "fehér", "zöld", "piros", "szürke", "ezüst", "sárga", "kék" };
            String szin;
            int maxIndex = szinek.Length;

            szin = szinek[rand.Next(maxIndex)];

            return szin;
        }

        public String Meretez()
        {
            String[] meretek = { "XS", "S", "M", "L", "XL" };
            String meret;
            int maxIndex = meretek.Length;

            meret = meretek[rand.Next(maxIndex)];

            return meret;
        }

       public Kutya CreateKutya()
        {
            Kutya kutya;

            String meret = Meretez();
         String szin=Szinez();
         if(szin == "zöld" || szin=="kék" || szin=="piros" || szin =="sárga" || szin=="ezüst")
            {
                szin = defaultSzin;
            }  

         int labakSzama = 4;
         Boolean tudRepulni = false ;
         Boolean tudUszni= boolRandomize();
         Boolean lakasBan =boolRandomize();


            kutya = new Kutya(meret, szin, tudRepulni, labakSzama, tudUszni, lakasBan);
                
        return kutya; 
       }

        public Madar CreateMadar()
        {
            Madar madar;

            String meret = Meretez();
            String szin = Szinez();
            int labakSzama = 2;
            Boolean tudRepulni = boolRandomize();
            Boolean tudUszni = boolRandomize();
            Boolean ragadozo = boolRandomize();
            Boolean kalitkaban = boolRandomize();


            madar = new Madar(meret, szin, tudRepulni, labakSzama, tudUszni, ragadozo,kalitkaban);

            return madar;
        }

        public Hal CreateHal()
        {
            Hal hal;

            String meret = Meretez();
            String szin = Szinez();
            int labakSzama = 0;
            Boolean tudRepulni = false;
            Boolean tudUszni = boolRandomize();
            Boolean edesvizi = boolRandomize();


            hal = new Hal(meret, szin, tudRepulni, labakSzama, tudUszni, edesvizi);

            return hal;
        }

        public Kigyo CreateKigyo()
        {
            Kigyo kigyo; ;

            String meret = Meretez();
            String szin = Szinez();
            int labakSzama = 0;
            Boolean tudRepulni = false;
            Boolean tudUszni = boolRandomize();
            Boolean merges = boolRandomize();


            kigyo = new Kigyo(meret, szin, tudRepulni, labakSzama, tudUszni, merges);

            return kigyo;
        }


    }
}
