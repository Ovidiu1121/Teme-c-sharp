using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.animal
{
    public class Leu:Animal
    {

        private string habitat;
        private string origine;
        private bool isDomestic;

        public Leu()
        {
            Console.WriteLine("Constructor cu 0 parametri din leu");
        }

        public Leu(string habitat,string origine,bool isDomestic)
        {
            this.habitat = habitat;
            this.origine = origine;
            this.isDomestic = isDomestic;
            Console.WriteLine("Constructor cu 0 parametri din leu");
        }

        public Leu(string habitat,int varsta,string specie):base(varsta,specie)
        {
            this.habitat = habitat;
            Console.WriteLine("Constructor cu 3 parametri din leu");
        }

        public string getHabitat()
        {
            return this.habitat;
        }

        public void setHabitat(string habitat)
        {
            this.habitat = habitat;
        }

        public string getOrigine()
        {
            return this.origine;
        }

        public void setOrigine(string origine)
        {
            this.origine = origine;
        }

        public bool getIsDomestic()
        {
            return this.isDomestic;
        }

        public void setIsDomestic(bool isDomestic)
        {
            this.isDomestic = isDomestic;
        }

        public string descriereLeu()
        {
            string text = base.descriereAnimal()+"\n";

            text+="habitat: "+this.habitat+", ";
            text+="origine: "+this.origine+", ";
            text+="is domestic: "+this.isDomestic;

            return text;
        }


    }
}
