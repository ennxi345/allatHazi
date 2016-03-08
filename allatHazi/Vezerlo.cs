using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatHazi
{
    class Vezerlo
    {
        public void start()
        {
            List<Kutya> kutyak = new List<Kutya>();
            List<Madar> madarak = new List<Madar>();
            List<Hal> halak = new List<Hal>();
            List<Kigyo> kigyok = new List<Kigyo>();
            Mock generator = new Mock();

            List<Kigyo> rendezettLista = new List<Kigyo>();
            List<Allat> allatok = new List<Allat>();
            Kigyo rendezettKigyo;


            for (int i = 0; i < 6; i++)
            {
                kutyak.Add(generator.CreateKutya());
                madarak.Add(generator.CreateMadar());
                halak.Add(generator.CreateHal());
                kigyok.Add(generator.CreateKigyo());

                rendezettKigyo = generator.CreateKigyo();
                rendezettLista.Add(rendezettKigyo);
            
            }

            allatok.AddRange(kutyak);
            allatok.AddRange(madarak);
            allatok.AddRange(halak);
            allatok.AddRange(kigyok);


            Console.WriteLine("A kutyák kiíratása:\n");
            //Kutyák kiíratása
            foreach (Kutya item in kutyak)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------\n");

            Console.WriteLine("A madarak kiíratása:\n");
            //Madarak kiiratása
            foreach (Madar item in madarak)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------\n");

            Console.WriteLine("A halak kiíratása:\n");
            //Halak kiiratás
            foreach (Hal item in halak)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------\n");

            Console.WriteLine("A kígyók kiíratása:\n");
            //Kigyok kiíratása
            foreach (Kigyo item in kigyok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------\n");

            Console.WriteLine("Az kígyók méret szerinti kiíratása :\n");
            //A kigyók méret szerint rendezve
            rendezettLista.Sort();
            foreach (Kigyo item in rendezettLista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------\n");

            Console.WriteLine("Az állatok  kiíratása:\n");
            //Az állatok listája 
            foreach (Allat item in allatok)
            {
                Console.WriteLine(item.ToString() + "  Hang:" + item.Hang);
            }

            Console.ReadKey();
        }
    }
}
