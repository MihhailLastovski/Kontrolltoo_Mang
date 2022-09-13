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
        public Tegelane suurimaEsemeteArvuga()
        {
            Tegelane player = characters[0];
            foreach (Tegelane item in characters)
            {
                player.CompareTo(item);
            }
        }


        public Tegelane suurimaPunktideArvuga()
        {
        }
    }
}
