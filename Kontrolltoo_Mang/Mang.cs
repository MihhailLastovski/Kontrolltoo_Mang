using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Mang 
    {
        private Tegelane[] characters;
        public Mang(Tegelane[] characters)
        {
            this.characters = characters;
        }
        public List <Tegelane> SuurimaEsemeteArvuga()
        {
            List<Tegelane> out_list = new List<Tegelane>();
            Tegelane player = characters[0];
            foreach (Tegelane item in characters)
            {
                int check = player.CompareTo(item);
                if (check < 0)
                {
                    player = item;
                    out_list.Clear();
                }
                if (check > 0)
                {
                    out_list.Add(item);
                }

            }
            out_list.Add(player);
            return out_list;
        }


    }
}
