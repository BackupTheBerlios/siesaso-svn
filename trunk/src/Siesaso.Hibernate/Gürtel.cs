using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Siesaso.Hibernate
{
    /// <summary>
    /// entität für die Gürtelfarben im Judo
    /// </summary>
    public class Gürtel : Entity<Gürtel>
    {

        protected override int PrimaryKey()
        {
            return id;
        }

        private int id;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String farbe;

        public virtual String Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }

        private int nummer;

        public virtual int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        private String name;

        public virtual String Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
