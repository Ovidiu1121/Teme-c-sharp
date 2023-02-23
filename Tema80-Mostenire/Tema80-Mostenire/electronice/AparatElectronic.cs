using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.electronice
{
    public class AparatElectronic
    {

        private string denumire;
        private string marca;
        private int pret;

        public AparatElectronic()
        {
            Console.WriteLine("constructoe cu 0 parametri din aparat electronic");
        }

        public AparatElectronic(string denumire)
        {
            this.denumire = denumire;
            Console.WriteLine("constructoe cu 1 parametru din aparat electronic");
        }

        public AparatElectronic(string denumire,int pret)
        {
            this.denumire=denumire;
            this.marca=marca;
            Console.WriteLine("constructoe cu 2 parametri din aparat electronic");
        }

        public AparatElectronic(string denumire,string marca, int pret)
        {
            this.denumire=denumire;
            this.marca=marca;
            this.pret=pret;
            Console.WriteLine("constructoe cu 3 parametri din aparat electronic");
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public void setDenumire(string denumire)
        {
            this.denumire = denumire;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public int getPret()
        {
            return this.pret;
        }

        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public string descriereAparatElectronic()
        {
            string text = "";

            text+="denumire: "+this.denumire+", ";
            text+="marca: "+this.marca+", ";
            text+="pret: "+this.pret;

            return text;
        }

    }
}
