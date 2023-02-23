using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.persoana
{
    public class Persoana
    {
        private string nume;
        private int varsta;
        private string ocupatie;

        public Persoana()
        {
            Console.WriteLine("constructor cu 0 parametri din persoana");
        }

        public Persoana(string nume,int varsta,string ocupatie)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.ocupatie = ocupatie;
            Console.WriteLine("constructor cu 3 parametri din persoana");
        }

        public Persoana( string ocupatie)
        {
            this.ocupatie = ocupatie;
            Console.WriteLine("constructor cu 1 parametru din persoana");
        }

        public string getNume()
        {
            return this.nume;
        }

        public void setNume(string nume)
        {
            this.nume=nume;
        }

        public int getVarsta()
        {
            return this.varsta;
        }

        public void setVarsta(int varsta)
        {
            this.varsta=varsta;
        }

        public string getOcupatie()
        {
            return this.ocupatie;
        }

        public void setOcupatie(string ocupatie)
        {
            this.ocupatie=ocupatie;
        }

        public string descrierePersoana()
        {
            string text = "";

            text+="nume: "+this.nume+", ";
            text+="varsta: "+this.varsta+", ";
            text+="ocupatie: "+this.ocupatie;

            return text;
        }

    }
}
