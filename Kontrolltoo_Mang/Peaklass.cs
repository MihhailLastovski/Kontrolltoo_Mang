using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    static class Peaklass
    {
        static Random rnd = new Random();

        public static List<Ese> LoeEsemed()
        {

            List<Ese> esed = new List<Ese>();
            using (StreamReader sr = new StreamReader(@"..\..\..\esemed.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Ese ese = new Ese(rida[0].ToString(), Int32.Parse(rida[1]));
                    esed.Add(ese);
                }
            }
            return esed;
        }
        public static string nimedArray()
        {
            string[] nimeArray = { "Nebula", "Sol", "Papanja", "Andromeda", "Hydraponica", "Fuji", "Vitas" };
            return nimeArray[rnd.Next(nimeArray.Length)];
        }
        static Tegelane[] tegelaseLoomine(int mangija)
        {
            if (mangija < 2) throw new Exception();
            Tegelane[] mangija_Array = new Tegelane[mangija];
            for (int i = 0; i < mangija; i++)
            {
                Tegelane mangija_ = new Tegelane(nimedArray());
                mangija_Array[i] = mangija_;
            }
            List<Ese> esedList = LoeEsemed();
            if (esedList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane mangijas in mangija_Array)
            {
                //var shuffled = esedList.OrderBy(_ => rnd.Next()).ToList();
                Shuffle(esedList);
                int kogus = rnd.Next(2, 10);
                for (int i = 0; i < kogus; i++)
                {
                    mangijas.valjastaEsemed(esedList[i]);
                }
            }
            return mangija_Array;

        }
            

        public static void Shuffle<T>(this IList<T> list) 
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static void mangida(int total_players)
        {
            Tegelane[] mangijad = tegelaseLoomine(total_players);
            Mang mang = new Mang(mangijad);
            foreach (Tegelane voitja in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(voitja.info());
            }
            Tegelane voit = mang.SuurimaPunktideArvuga();
            Console.WriteLine();
            Console.WriteLine("VÕITJA: ");
            voit.info();
            Console.WriteLine();
            Console.WriteLine("Mängijal olid järgmisel esed: ");
            Console.WriteLine("--------------------------------");
            voit.valjastaEsemed();
            Console.WriteLine("--------------------------------");


        }
        public static void start(int plrcount)
        {
            while (true)
            {
                Console.WriteLine("Kas soovite mängu mängida? Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {


                    Console.Clear();
                    mangida(plrcount);




                }
                else
                {
                    break;
                }
            }
            
            
            
        }

       

    }
}
