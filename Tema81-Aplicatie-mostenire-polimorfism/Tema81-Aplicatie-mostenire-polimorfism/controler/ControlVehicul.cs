using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema81_Aplicatie_mostenire_polimorfism.vehicul;

namespace Tema81_Aplicatie_mostenire_polimorfism.controler
{
    internal class ControlVehicul
    {

        public List<Vehicul>lista =new List<Vehicul>();

        public ControlVehicul()
        {
            this.load();
        }

        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Data\charp\Teme\Tema81-Aplicatie-mostenire-polimorfism\Tema81-Aplicatie-mostenire-polimorfism\bin\Debug\net6.0\ref\data\vehicule.txt");

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                switch (line.Split(",")[0])
                {
                    case "masina":this.lista.Add(new Masina(line));
                        break;
                }
             
            }

        }

        public void afisare()
        {

            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i].description());
            }

        }








    }
}
