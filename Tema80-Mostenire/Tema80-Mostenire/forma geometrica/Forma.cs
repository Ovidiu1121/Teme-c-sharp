using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire
{
    public class Forma
    {
        private int arie;
        private int inaltime;
        private string denumire;

        public Forma()
        {
            Console.WriteLine("constructor cu 0 parametri din forma");
        }

        public Forma(int arie,int inaltime,string denumire)
        {
            this.arie = arie;
            this.inaltime = inaltime;
            this.denumire = denumire;
            Console.WriteLine("constructor cu 3 parametri din forma");
        }

        public Forma(int arie,string denumire)
        {
            this.arie=arie;
            this.denumire=denumire;
            Console.WriteLine("constructor cu 2 parametri din forma");
        }

        public int getArie()
        {
            return this.arie;
        }

        public void setArie(int arie)
        {
            this.arie = arie;
        }

        public int getInaltime()
        {
            return this.inaltime;
        }

        public void setInaltime(int inaltime)
        {
            this.inaltime=inaltime;
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public void setDenumire(string denumire)
        {
            this.denumire=denumire;
        }

        public string descriereForma()
        {

            string text = "";

            text+="arie: "+this.arie+", ";
            text+="inaltime: "+this.inaltime+", ";
            text+="denumire: "+this.denumire;

            return text;

        }


    }
}
