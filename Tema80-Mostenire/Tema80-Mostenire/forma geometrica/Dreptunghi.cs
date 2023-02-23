using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema80_Mostenire.forma_geometrica
{
    public class Dreptunghi:Forma
    {
        private int lungime;
        private int latime;
        private int perimetru;

        public Dreptunghi() : base()
        {
            Console.WriteLine("constructor cu 0 parametri din dreptunghi");
        }

        public Dreptunghi(int lungime,int latine) : base()
        {
            this.lungime = lungime;
            this.latime = latine;
            Console.WriteLine("constructor cu 2 parametri din dreptunghi");
        }

        public Dreptunghi(int lungime, int latine,int parametru,int arie,string denumire) : base(arie,denumire)
        {
            this.lungime = lungime;
            this.latime = latine;
            this.perimetru = parametru;
            Console.WriteLine("constructor cu 2 parametri din dreptunghi");
        }

        public Dreptunghi(int perimetru,int arie,int inaltime,string denumire) : base(arie, inaltime, denumire)
        {
            this.perimetru=perimetru;
            Console.WriteLine("constructor cu 4 parametri din dreptunghi");
        }

        public int getLungime()
        {
            return this.lungime;
        }

        public void setLungime(int lungime)
        {
            this.lungime=lungime;
        }

        public int getLatime()
        {
            return this.latime;
        }

        public void setLatime(int latime)
        {
            this.latime=latime;
        }

        public int getPerimetru()
        {
            return this.perimetru;
        }

        public void setPerimetru(int perimetru)
        {
            this.perimetru=perimetru;
        }

        public string descriereDreptunghi()
        {
            string text = base.descriereForma()+"\n";

            text+="lungime: "+this.lungime+", ";
            text+="latime: "+this.latime+", ";
            text+="perimetru: "+this.perimetru;

            return text;
        }

    }
}
