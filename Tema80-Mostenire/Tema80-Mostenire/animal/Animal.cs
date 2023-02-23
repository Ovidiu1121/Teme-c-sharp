using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.animal
{
    public class Animal
    {

        private int varsta;
        private string specie;
        private int greutate;

        public Animal()
        {
            Console.WriteLine("constructor cu 0 parametri din animal");
        }

        public Animal(int varsta,string specie,int greutate)
        {
            this.varsta = varsta;
            this.specie = specie;
            this.greutate = greutate;
            Console.WriteLine("constructor cu 3 parametri din animal");
        }

        public Animal(string specie)
        {
            this.specie = specie;
            Console.WriteLine("constructor cu 1 parametru din animal");
        }

        public Animal(int varsta, string specie)
        {
            this.varsta = varsta;
            this.specie = specie;
            Console.WriteLine("constructor cu 2 parametri din animal");
        }

        public int getVarsta()
        {
            return this.varsta;
        }

        public void setVarsta(int varsta)
        {
            this.varsta = varsta;
        }

        public string getSpecie()
        {
            return this.specie;
        }

        public void setSpecie(string specie)
        {
            this.specie = specie;
        }

        public int getGreutate()
        {
            return this.greutate;
        }

        public void setGreutate(int greutate)
        {
            this.greutate = greutate;
        }

        public string descriereAnimal()
        {
            string text = "";

            text+="varsta: "+this.varsta+", ";
            text+="specie: "+this.specie+", ";
            text+="greutate: "+this.greutate;

            return text;
        }

    }
}
