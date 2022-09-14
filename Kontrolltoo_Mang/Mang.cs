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
        private Tegelane[] tegelaste;
        public Mang(Tegelane[] tegelaste)
        {
            this.tegelaste = tegelaste;
        }
        public List<Tegelane> SuurimaEsemeteArvuga()
        {
            Tegelane mangija = tegelaste[0];
            List<Tegelane> tegelased = new List<Tegelane>();
            foreach (Tegelane item in tegelaste)
            {
                int check = mangija.CompareTo(item);
                if (check < 0)
                {
                    mangija = item;
                    tegelased.Clear();
                }
                if (check == 0) tegelased.Add(item);

            }
            tegelased.Add(mangija);
            return tegelased;
        }
        public Tegelane SuurimaPunktideArvuga()
        {
            int korgem = 0;
            Tegelane voitja = tegelaste[0];
            foreach (Tegelane mangija in tegelaste)
            {
                int arv = mangija.punktideArv();
                if (arv > korgem) { korgem = arv; voitja = mangija; }
            }
            return voitja;
        }

    }
}
