using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema81_Aplicatie_mostenire_polimorfism.vehicul
{
    public class Vehicul
    {

        private string type;
        private string brand;
        private string fuel;

        public Vehicul()
        {

        }

        public Vehicul(string type, string brand, string fuel)
        {
            this.type = type;
            this.brand = brand;
            this.fuel = fuel;
        }

        public Vehicul(string prop)
        {
            string[] a = prop.Split(",");

            this.type=a[0];
            this.brand = a[1];
            this.fuel = a[2];


        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public virtual string description()
        {
            string text = "";

            text+="type: "+this.type+", ";
            text+="brand: "+this.brand+", ";
            text+="fuel: "+this.fuel+", ";

            return text;

        }


    }
}
