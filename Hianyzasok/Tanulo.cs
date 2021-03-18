using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzasok
{
    class Tanulo
    {
        private string nev;
        private string osztaly;
        private int elso;
        private int utolso;
        private int mulasztott;


        public string Nev { get { return nev; } }
        public string Osztaly { get { return osztaly; } }
        public int Elso { get { return elso; } }
        public int Utolso { get { return utolso; } }
        public int Mulasztott { get { return mulasztott; } }

        public Tanulo(string nev, string osztaly, int elso, int utolso, int mulasztott)
        {
            this.nev = nev;
            this.osztaly = osztaly;
            this.elso = elso;
            this.utolso = utolso;
            this.mulasztott = mulasztott;
        }
    }
}
