using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Hibernate
{
    public class Verein : Entity<Verein>
    {
        private int id;
        private String name;
        private String langname;
        private String adresse;
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
	
        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
	
        public String Langname
        {
            get { return langname; }
            set { langname = value; }
        }
	
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
	
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        protected override int PrimaryKey()
        {
            return id;
        }
    }
}
