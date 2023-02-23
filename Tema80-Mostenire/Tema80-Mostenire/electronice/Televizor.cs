using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.electronice
{
    internal class Televizor:AparatElectronic
    {

        private int rezolutie;
        private int programe;
        private string tipEcran;

        public Televizor()
        {
            Console.WriteLine("COnstructor cu 0 parametri din televizor");
        }

        public Televizor(int rezolutie,int programe,string tipEcran,string denumire):base(denumire)
        {
            this.rezolutie = rezolutie;
            this.programe = programe;
            this.tipEcran = tipEcran;
            Console.WriteLine("COnstructor cu 4 parametri din televizor");
        }

        public Televizor(int rezolutie, string tipEcran, string denumire,int pret,string marca) : base(denumire,marca,pret)
        {
            this.rezolutie = rezolutie;
            this.tipEcran = tipEcran;
            Console.WriteLine("COnstructor cu 5 parametri din televizor");
        }

        public int getRezolutie()
        {
            return this.rezolutie;
        }

        public void setRezolutie(int rezolutie)
        {
            this.rezolutie = rezolutie;
        }

        public int getPrograme()
        {
            return this.programe;
        }

        public void setPrograme(int programe)
        {
            this.programe = programe;
        }

        public string getTipEcran()
        {
            return this.tipEcran;
        }

        public void setTipEcran(string tipEcran)
        {
            this.tipEcran = tipEcran;
        }

        public string descriereTelevizor()
        {
            string text = base.descriereAparatElectronic()+"\n";

            text+="rezolutie: "+this.rezolutie+", ";
            text+="programe: "+this.programe+", ";
            text+="tipEcran: "+this.tipEcran;

            return text;
        }


    }
}
