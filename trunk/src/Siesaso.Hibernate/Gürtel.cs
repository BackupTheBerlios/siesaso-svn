using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// entität für die Gürtelfarben im Judo
    /// </summary>
    public class Gürtel : Internal.Entity<Gürtel>
    {

        #region Überschreibungen

        protected override int PrimaryKey()
        {
            return id;
        }

        public override string ToString()
        {
            return name;
        }

        #endregion

        #region Mapping

        private int id;

        private String name;

        private String farbe;

        private int nummer;

        
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual String Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }

        public virtual int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        public virtual String Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

    }
}
