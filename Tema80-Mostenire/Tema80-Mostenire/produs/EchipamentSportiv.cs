using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.produs
{
    public class EchipamentSportiv:Produs
    {

        private string denumire;
        private int greutate;
        private string material;

        public EchipamentSportiv()
        {
            Console.WriteLine("constructor cu 0 parametri din echipament sportiv");
        }

        public EchipamentSportiv(string denumire, int greutate,string material,int pret):base(pret)
        {
            this.denumire = denumire;
            this.greutate = greutate;
            this.material = material;
            Console.WriteLine("constructor cu 4 parametri din echipament sportiv");
        }

        public EchipamentSportiv(string denumire, int pret,int stoc) : base(pret,stoc)
        {
            this.denumire = denumire;
            Console.WriteLine("constructor cu 3 parametri din echipament sportiv");
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public void setDenumire(string denumire)
        {
            this.denumire = denumire;
        }

        public int getGreutate()
        {
            return this.greutate;
        }

        public void setGreutate(int greutate)
        {
            this.greutate = greutate;
        }

        public string getMaterial()
        {
            return this.material;
        }

        public void setMaterial(string material)
        {
            this.material = material;
        }

        public string descriereEchipamentSportiv()
        {
            string text = base.descriereProdus()+"\n";

            text+="denumire: "+this.denumire+", ";
            text+="greutate: "+this.greutate+", ";
            text+="material: "+this.material;

            return text;
        }




    }
}
