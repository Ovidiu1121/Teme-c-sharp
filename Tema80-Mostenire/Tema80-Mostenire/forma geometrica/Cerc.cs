using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.forma_geometrica
{
    public class Cerc:Forma
    {
        private int raza;
        private int diametru;
        private int circumferinta;

        public Cerc(int raza, int diametru, int circumferinta, int arie, int inaltime, string denumire) : base(arie, inaltime, denumire)
        {
            this.raza = raza;
            this.diametru = diametru;
            this.circumferinta = circumferinta;
            Console.WriteLine("Constructor cu 6 parametri din cerc");
        }

        public Cerc(int raza,int diametru,int arie,string denumire) : base(arie, denumire)
        {
            this.raza = raza;
            this.diametru=diametru;
            Console.WriteLine("Constructor cu 4 parametri din cerc");
        }

        public Cerc(int raza, int diametru, int circumferinta) : base()
        {
            this.raza = raza;
            this.diametru = diametru;
            this.circumferinta = circumferinta;
            Console.WriteLine("Constructor cu 3 parametri din cerc");
        }

        public int getRaza()
        {
            return this.raza;
        }

        public void setRaza(int raza)
        {
            this.raza=raza;
        }

        public int getDiametru()
        {
            return this.diametru;
        }

        public void setDiametru(int diametru)
        {
           this.diametru=diametru;
        }

        public int getCircumferinta()
        {
            return this.circumferinta;
        }

        public void setCircumferinta(int circumferinta)
        {
            this.circumferinta=circumferinta;
        }

        public string descriereCerc()
        {
            string text = base.descriereForma()+"\n";

            text+="raza: "+this.raza+", ";
            text+="diametru: "+this.diametru+", ";
            text+="circumferinta: "+this.circumferinta;

            return text;
        }




    }
}
