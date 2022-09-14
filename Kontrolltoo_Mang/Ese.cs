using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Ese : IUksus
    {
        private string nimetus;
        private int punktide_arv;

        public Ese(string nimetus, int punktide_arv)
        {
            this.nimetus = nimetus;
            this.punktide_arv = punktide_arv;
        }

        public string info()
        {
            Console.WriteLine(nimetus);
            return nimetus; 
        }

        public int punktideArv() { return punktide_arv; }
        
    }
}
