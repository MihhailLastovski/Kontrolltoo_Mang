using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    class Tegelane : Uksus, IComparable<Tegelane>
    {
        private string nimi;
        private List<Ese> ese_list = new List<Ese>();
        protected double m_value = 0.0;
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public int addItem(int item) 
        { return item; }
        public int punktideArv()
        {
            int arv_sum = 0;
            foreach (Ese item in ese_list)
            {
                arv_sum += item.punktideArv(); 
            }
            return arv_sum;
        }
        //public int punktideArv_(List <Ese> list)
        //{
            
        //    foreach (Ese item in list)
        //    {
        //        arv_sum_ += item.punktideArv();
        //    }
        //    return arv_sum_;
        //}

        public string info()
        {
            Console.WriteLine($"Nimi: {nimi}\nArvu punktide {punktideArv()}");
            return $"Nimi: {nimi}\nArvu punktide {punktideArv()}";
        }
       

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return m_value.CompareTo(other.m_value);
        }
        public void issueItems(List<Ese> list, int item)
        {
            Ese help_check = list[item];
            ese_list.Add(list[item]);
            Console.WriteLine(help_check.info()); 

        }
    }
}
