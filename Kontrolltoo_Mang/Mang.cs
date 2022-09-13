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
        public List <Tegelane> suurimaEsemeteArvuga()
        {
            Tegelane player = characters[0];
            List<Tegelane> out_list = new List<Tegelane>();
            foreach (Tegelane item in characters)
            {
                
                int check = player.CompareTo(item);
                if (check < 0)
                {
                    player = item;
                    out_list.Clear();

                }
                else if (check > 0)
                { 
                    out_list.Add(item);
                }
                out_list.Add(player);
                return out_list;
            }
        }


    }
}
