using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.animal
{
    internal class Reptila:Animal
    {
        private bool areSolzi;
        private bool poateInota;
        private string tipHrana;

        public Reptila()
        {
            Console.WriteLine("constructor cu 0 parametri din reptila");
        }

        public Reptila(bool areSolzi,bool poateInota,string tipHrana,int varsta,string specie,int greutate):base(varsta,specie,greutate)
        {
            this.areSolzi = areSolzi;
            this.poateInota = poateInota;
            this.tipHrana = tipHrana;
            Console.WriteLine("constructor cu 0 parametri din reptila");
        }

        public Reptila(bool areSolzi, bool poateInota, string tipHrana, string specie) : base(specie)
        {
            this.areSolzi = areSolzi;
            this.poateInota = poateInota;
            this.tipHrana = tipHrana;
            Console.WriteLine("constructor cu 4 parametri din reptila");
        }

        public bool getAreSolzi()
        {
            return this.areSolzi;
        }

        public void setAreSolzi(bool areSolzi)
        {
            this.areSolzi = areSolzi;
        }

        public bool getPoateInota()
        {
            return this.poateInota;
        }

        public void setPoateInota(bool poateInota)
        {
            this.poateInota = poateInota;
        }

        public string getTipHrana()
        {
            return this.tipHrana;
        }

        public void setTipHrana(string tipHrana)
        {
            this.tipHrana = tipHrana;
        }

        public string descriereReptila()
        {
            string text = base.descriereAnimal()+"\n";

            text+="are solzi: "+this.areSolzi+", ";
            text+="poate inota: "+this.poateInota+", ";
            text+="tip hrana: "+this.tipHrana;

            return text;
        }



    }
}
