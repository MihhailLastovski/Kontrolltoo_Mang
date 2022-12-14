using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    class Tegelane : IUksus, IComparable<Tegelane>
    {
        private string nimi;
        private List<Ese> ese_list = new List<Ese>();
        public Tegelane(string nimi)
        {
            this.nimi = nimi;

        }
        public int lisaEse(int valik) 
        { return valik; }
        public int punktideArv()
        {
            int arv_sum = 0;
            foreach (Ese item in ese_list)
            {
                arv_sum += item.punktideArv(); 
            }
            return arv_sum;
        }
        public string info()
        {
            Console.WriteLine($"Nimi: {nimi}\nArvu punktide {punktideArv()}");
            return $"Nimi: {nimi}\nArvu punktide {punktideArv()}";
        }
        public void valjastaEsemed() 
        {
            foreach (Ese item in ese_list)
            {
                item.info();
            }
            Console.WriteLine();
        }

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.ese_list.Count - other.EsesKogus();
        }
        private int EsesKogus() { return this.ese_list.Count; }
        //public void valjastaEsemed(List<Ese> list, int item)
        //{
        //    ese_list.Add(list[item]);
        //}
        public void valjastaEsemed(Ese ese) { ese_list.Add(ese); }
    }
}
