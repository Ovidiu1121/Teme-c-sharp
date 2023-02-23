using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.persoana
{
    public  class Stomatolog:Persoana
    {

        private string locatie;
        private int salariu;
        private string specializare;

        public Stomatolog()
        {
            Console.WriteLine("constructor cu 0 parametri din stomatolog");
        }

        public Stomatolog(string locatie,int salariu,string specializare,string nume,int varsta,string ocupatie):base(nume,varsta,ocupatie)
        {
            this.locatie = locatie;
            this.salariu = salariu;
            this.specializare = specializare;
            Console.WriteLine("constructor cu 6 parametri din stomatolog");
        }

        public Stomatolog(string locatie, int salariu, string ocupatie) : base( ocupatie)
        {
            this.locatie = locatie;
            this.salariu = salariu;
            Console.WriteLine("constructor cu 3 parametri din stomatolog");
        }

        public string getLocatie()
        {
            return this.locatie;
        }

        public void setLocatie(string locatie)
        {
            this.locatie = locatie;
        }

        public int getSalariu()
        {
            return this.salariu;
        }

        public void setSalariu(int salariu)
        {
            this.salariu = salariu;
        }

        public string getSpecializare()
        {
            return this.specializare;
        }

        public void setSpecializare(string specializare)
        {
            this.specializare = specializare;
        }

        public string descriereStomatolog()
        {
            string text = base.descrierePersoana()+"\n";

            text+="locatie: "+this.locatie+", ";
            text+="salariu: "+this.salariu+", ";
            text+="specializare: "+this.specializare;

            return text;
        }


    }
}
