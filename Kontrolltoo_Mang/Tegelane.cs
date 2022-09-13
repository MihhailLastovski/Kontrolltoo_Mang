﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Tegelane : Uksus, IComparable<Tegelane>
    {
        private string nimi;
        private List<Ese> ese_list = new List<Ese>();

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public int addItem(int item) { return item; }
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
            Console.WriteLine($"Nimi: {nimi}\nArvu punktide{punktideArv()}");
            return $"Nimi: {nimi}\nArvu punktide{punktideArv()}";
        }
        public void issueItems() 
        {
            foreach (Ese item in ese_list)
            {
                Console.WriteLine($"\n{item}");
            }
        }

        public int CompareTo(Tegelane? other)
        {
            throw new NotImplementedException();
        }
    }
}