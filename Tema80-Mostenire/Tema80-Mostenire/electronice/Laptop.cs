using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.electronice
{
    public class Laptop:AparatElectronic
    {

        private string procesor;
        private int memorie;
        private int dimensiune;

        public Laptop()
        {
            Console.WriteLine("constructor cu 0 parametri din Laptop");
        }

        public Laptop(string procesor,int memorie,int dimensiune,string denumire,int pret):base(denumire,pret)
        {
            this.procesor = procesor;
            this.memorie = memorie;
            this.dimensiune = dimensiune;
            Console.WriteLine("constructor cu 5 parametri din Laptop");
        }

        public Laptop(string procesor, int memorie, string denumire) : base(denumire)
        {
            this.procesor = procesor;
            this.memorie = memorie;
            Console.WriteLine("constructor cu 3 parametri din Laptop");
        }

        public string getProcesor()
        {
            return this.procesor;
        }

        public void setProcesor(string procesor)
        {
            this.procesor = procesor;
        }

        public int getMemorie()
        {
            return this.memorie;
        }

        public void setMemorie(int memorie)
        {
            this.memorie = memorie;
        }

        public int getDimensiune()
        {
            return this.dimensiune;
        }

        public void setDimensiune(int dimensiune)
        {
            this.dimensiune = dimensiune;
        }

        public string descriereLaptop()
        {
            string text = base.descriereAparatElectronic()+"\n";

            text+="procesor: "+this.procesor+", ";
            text+="memorie: "+this.memorie+", ";
            text+="dimensiune: "+this.dimensiune;

            return text;
        }






    }
}
