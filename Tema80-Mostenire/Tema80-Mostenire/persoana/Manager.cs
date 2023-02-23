using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.persoana
{
    public class Manager:Persoana
    {
        private int telefon;
        private int salariu;
        private int departament;

        public Manager()
        {
            Console.WriteLine("constructor cu 0 parametri din manager");
        }

        public Manager(int telefon,int salariu, int departament,string nume,int varsta,string ocupatie):base(nume,varsta,ocupatie)
        {
            this.telefon = telefon;
            this.salariu = salariu;
            this.departament = departament;
            Console.WriteLine("constructor cu 6 parametri din manager");
        }

        public Manager(int telefon, string ocupatie) : base( ocupatie)
        {
            this.telefon = telefon;
            Console.WriteLine("constructor cu 2 parametri din manager");
        }

        public int getTelefon()
        {
            return this.telefon;
        }

        public void setTelefon(int telefon)
        {
            this.telefon = telefon;
        }

        public int getSalariu()
        {
            return this.salariu;
        }

        public void setSalariu(int salariu)
        {
            this.salariu = salariu;
        }

        public int getDepartament()
        {
            return this.departament;
        }

        public void setDepartament(int departament)
        {
            this.departament = departament;
        }

        public string descriereManager()
        {
            string text = base.descrierePersoana()+"\n";

            text+="telefon: "+this.telefon+", ";
            text+="salariu: "+this.salariu+", ";
            text+="departament: "+this.departament;

            return text;
        }

    }
}
