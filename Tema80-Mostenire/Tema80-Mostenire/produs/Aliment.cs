using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.produs
{
    internal class Aliment:Produs
    {

        private string denumire;
        private string ingrediente;
        private int dataExpirarii;

        public Aliment()
        {
            Console.WriteLine("constructor cu 0 parametri din aliment");
        }

        public Aliment(string denumire,string ingrediente,int dataExpirarii,int pret):base(pret)
        {
            this.denumire = denumire;
            this.ingrediente = ingrediente;
            this.dataExpirarii = dataExpirarii;
            Console.WriteLine("constructor cu 4 parametri din aliment");
        }

        public Aliment(string denumire, string ingrediente, int dataExpirarii, int pret,int stoc,string producator) : base(pret,stoc,producator)
        {
            this.denumire = denumire;
            this.ingrediente = ingrediente;
            this.dataExpirarii = dataExpirarii;
            Console.WriteLine("constructor cu 6 parametri din aliment");
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public void setDenumire(string denumire)
        {
            this.denumire = denumire;
        }

        public string getIngrediente()
        {
            return this.ingrediente;
        }

        public void setIngrediente(string ingrediente)
        {
            this.ingrediente = ingrediente;
        }

        public int getDataExpirarii()
        {
            return this.dataExpirarii;
        }

        public void setDataExpirarii(int dataExpirarii)
        {
            this.dataExpirarii = dataExpirarii;
        }

        public string descriereAliment()
        {
            string text = base.descriereProdus()+"\n";

            text+="denumire: "+this.denumire+", ";
            text+="ingrediente: "+this.ingrediente+", ";
            text+="dataExpirarii: "+this.dataExpirarii;

            return text;
        }
    }
}
