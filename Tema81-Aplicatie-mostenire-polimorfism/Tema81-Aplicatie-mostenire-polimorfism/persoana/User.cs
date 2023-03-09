using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema81_Aplicatie_mostenire_polimorfism.persoana
{
    public class User:Persoana
    {
        private string prenume;
        private string parola;

        public User()
        {

        }

        public User(string prenume, string parola) : base()
        {
            this.prenume = prenume;
            this.parola = parola;
        }

        public User(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.prenume = a[3];
            this.parola = a[4];

        }

        public string Prenume
        {
            get { return this.prenume; }
            set { this.prenume = value; }
        }

        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value; }
        }

        public override string description()
        {

            string text = base.description();

            text+="prenume: "+this.prenume+", ";
            text+="parola: "+this.parola;

            return text;

        }



    }
}
