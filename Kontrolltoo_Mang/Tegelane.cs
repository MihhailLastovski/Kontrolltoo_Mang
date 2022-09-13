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
        int arv_sum_ = 0;
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
        public int punktideArv_(List <Ese> list, StreamReader from_file)
        {
            string text;
            while ((text = from_file.ReadLine()) != null)
            {
                string[] values = text.Split(';');
                list.Add(new Ese(values[0], int.Parse(values[1])));
            }

            from_file.Close();
            foreach (Ese item in list)
            {
                arv_sum_ += item.punktideArv();
            }
            return arv_sum_;
        }

        public string info()
        {
            Console.WriteLine($"Nimi: {nimi}\nArvu punktide {arv_sum_}");
            return $"Nimi: {nimi}\nArvu punktide {arv_sum_}";
        }
       

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return m_value.CompareTo(other.m_value);
        }
        public void issueItems(List<Ese> list, int item)
        {
            Ese qwe = list[item];
            qwe.info();

        }
    }
}
