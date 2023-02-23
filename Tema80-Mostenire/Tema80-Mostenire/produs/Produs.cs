using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.produs
{
    public class Produs
    {

        private int pret;
        private int stoc;
        private string producator;

        public Produs()
        {
            Console.WriteLine("constructor cu 0 parametri din produs");
        }

        public Produs(int pret,int stoc,string producator)
        {
            this.pret = pret;
            this.stoc = stoc;
            this.producator = producator;
            Console.WriteLine("constructor cu 3 parametri din produs");
        }

        public Produs(int pret, int stoc)
        {
            this.pret = pret;
            this.stoc = stoc;
            Console.WriteLine("constructor cu 2 parametri din produs");
        }

        public Produs(int pret)
        {
            this.pret = pret;
            Console.WriteLine("constructor cu 1 parametru din produs");
        }

        public int getPret()
        {
            return this.pret;
        }

        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public int getStoc()
        {
            return this.stoc;
        }

        public void setStoc(int stoc)
        {
            this.stoc = stoc;
        }

        public string getProducator()
        {
            return this.producator;
        }

        public void setProducator(string producator)
        {
            this.producator = producator;
        }

        public string descriereProdus()
        {
            string text = "";

            text+="pret: "+this.pret+", ";
            text+="stoc: "+this.stoc+", ";
            text+="producator: "+this.producator;

            return text;
        }

    }
}
