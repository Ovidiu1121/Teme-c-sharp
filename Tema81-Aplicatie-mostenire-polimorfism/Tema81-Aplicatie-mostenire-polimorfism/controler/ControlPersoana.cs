using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema81_Aplicatie_mostenire_polimorfism.persoana;

namespace Tema81_Aplicatie_mostenire_polimorfism.controler
{
    internal class ControlPersoana
    {
        public List<Persoana> lista=new List<Persoana>();

        public ControlPersoana()
        {
            this.load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Data\charp\Teme\Tema81-Aplicatie-mostenire-polimorfism\Tema81-Aplicatie-mostenire-polimorfism\bin\Debug\net6.0\ref\data\persoane.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {

                switch (line.Split(",")[0])
                {

                    case "admin":

                        this.lista.Add(new Admin(line));
                        break;
                    case "user":
                        this.lista.Add(new User(line));
                        break;

                }
            }

        }

        public void afisare()
        {

            for (int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i].description());
            }
        }



    }
}
