using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    public class Tegelane : Uksus, IComparable<Tegelane>
    {
        private string nimi;
        private List<Ese> ese_list = new List<Ese>();
        protected double m_value = 0.0;
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public int addItem(int punktideArv) 
        { return punktideArv; }
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
            if (other == null) return 1;
            return m_value.CompareTo(other.m_value);
        }
        public static bool operator >(Tegelane operand1, Tegelane operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        // Define the is less than operator.
        public static bool operator <(Tegelane operand1, Tegelane operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Tegelane operand1, Tegelane operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Tegelane operand1, Tegelane operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

    }
}
