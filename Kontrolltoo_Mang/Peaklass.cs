using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string Namesforgame()
        {
            string[] namesArray = { "Nebula", "Sol", "Papanja", "Andromeda", "Hydraponica", "Fuji", "Vitas" };
            return namesArray[rnd.Next(namesArray.Length)];
        }
        static Tegelane[] createPlayers(int players_)
        {
            if (players_ < 2) throw new Exception();
            Tegelane[] players_Array = new Tegelane[players_];
            for (int i = 0; i < players_; i++)
            {
                Tegelane plr = new Tegelane(Namesforgame());
                players_Array[i] = plr;
            }
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane plr in players_Array)
            {
                //var shuffled = itemList.OrderBy(_ => rnd.Next()).ToList();
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    plr.Equip(itemList[i]);
                }
            }
            return players_Array;

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
        public static void PlayGame(int total_players)
        {
            Tegelane[] players = createPlayers(total_players);
            Mang game = new Mang(players);
            foreach (Tegelane winner in game.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(winner.info());
            }
            Tegelane win = game.SuurimaPunktideArvuga();
            Console.WriteLine();
            Console.WriteLine("WINNER: ");
            win.info();
            Console.WriteLine();
            Console.WriteLine("Mängijal olid järgmisel esed: ");
            win.valjastaEsemed();


        }
        public static void start(int plrcount)
        {
            PlayGame(plrcount);
        }

       

    }
}
