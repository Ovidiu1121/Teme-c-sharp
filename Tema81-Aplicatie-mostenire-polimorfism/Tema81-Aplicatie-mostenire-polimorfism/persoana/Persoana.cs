﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema81_Aplicatie_mostenire_polimorfism.persoana
{
    public class Persoana
    {
        private string type;
        private string name;
        private int age;

        public Persoana()
        {

        }

        public Persoana(string type, string name, int age)
        {
            this.type = type;
            this.name = name;
            this.age = age;
        }

        public Persoana(string prop)
        {
            string[] a = prop.Split(",");

            this.type=a[0];
            this.name = a[1];
            this.age =int.Parse(a[2]);

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual string description()
        {

            string text = "";

            text+="type: "+this.type+",";
            text+="name: "+this.name+",";
            text+="age: "+this.age+",";

            return text;

        }



    }
}
