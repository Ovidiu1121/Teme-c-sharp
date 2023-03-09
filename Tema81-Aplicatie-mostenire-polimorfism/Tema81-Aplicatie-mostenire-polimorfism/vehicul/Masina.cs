using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema81_Aplicatie_mostenire_polimorfism.vehicul
{
    public class Masina:Vehicul
    {
        private string transmission;
        private int manufacturingYear;
        private int horsePower;

        public Masina()
        {

        }

        public Masina(string transmission, int manufactoringYear, int horsePower) : base()
        {
            this.transmission = transmission;
            this.manufacturingYear = manufactoringYear;
            this.horsePower = horsePower;
        }

        public Masina(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.transmission = a[3];
            this.manufacturingYear=int.Parse(a[4]);
            this.horsePower=int.Parse(a[5]);

        }

        public string Transmission
        {
            get { return this.transmission; }
            set { this.transmission = value; }
        }

        public int ManufacturingYear
        {
            get { return this.manufacturingYear; }
            set { this.manufacturingYear = value; }
        }

        public int HoursePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public override string description()
        {
            string text = base.description();

            text+="transmission: "+this.transmission+", ";
            text+="manufactoring year: "+this.manufacturingYear+", ";
            text+="hourse power: "+this.horsePower+", ";

            return text;
        }

    }
}
