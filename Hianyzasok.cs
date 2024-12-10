using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok_241210
{
    internal class Hianyzasok
    {
        string nev;
        string osztaly;
        int hanyadika;
        int igazolt;
        int nigazolt;

        public string Nev { get => nev; set => nev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public int Hanyadika { get => hanyadika; set => hanyadika = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Nigazolt { get => nigazolt; set => nigazolt = value; }

        public Hianyzasok(string sor) 
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            osztaly = darabok[1];
            hanyadika = Convert.ToInt32(darabok[2]);
            igazolt = Convert.ToInt32(darabok[3]);
            nigazolt = Convert.ToInt32(darabok[4]);
        }

        public int NapiHianyzasSzamolas()
        {
            return igazolt + nigazolt;
        }
    }
}
