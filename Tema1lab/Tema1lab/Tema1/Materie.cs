using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1lab.Tema1
{
    public class Materie
    {
        public string titlu { get; set; }
        public int durata { get; set; }
        public int An { get; set; }

        public Materie(string titlu, int durata, int An)
        {
            this.titlu = titlu;
            this.durata = durata;


        }
    }

}