using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema81_Aplicatie_mostenire_polimorfism.persoana
{
    public class Admin:Persoana
    {

        private string email;
        private string department;

        public Admin()
        {

        }

        public Admin(string email, string department) : base()
        {
            this.email = email;
            this.department = department;
        }

        public Admin(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.email = a[3];
            this.department = a[4];

        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string description()
        {
            string text = base.description();

            text+="email: "+this.email+", ";
            text+="department: "+this.department;

            return text;
        }


    }
}
