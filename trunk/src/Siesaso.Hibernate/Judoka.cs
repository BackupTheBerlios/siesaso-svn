using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// Entität für einen Judoka
    /// </summary>
    public class Judoka : Internal.Entity<Judoka>
    {

        #region Überschreibungen

        protected override int PrimaryKey()
        {
            return id;
        }

        public override string ToString()
        {
            if (zusatz == null) return vorname + " " + nachname; 
            else return vorname + " '" + zusatz+ "' " + nachname;
        }

        #endregion

        #region Mapping

        private int id;

        private String vorname;

        private String nachname;

        private String zusatz;

        private DateTime geburtsdatum;

        private Gürtel gürtel;

        private Geschlecht geschlecht;

        private Verein verein;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public virtual String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        public virtual String Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }

        public virtual DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; }
        }

        public virtual Gürtel Gürtel
        {
            get { return gürtel; }
            set { gürtel = value; }
        }

        public virtual Geschlecht Geschlecht
        {
            get { return geschlecht; }
            set { geschlecht = value; }
        }

        public virtual Verein Verein
        {
            get { return verein; }
            set { verein = value; }
        }

        #endregion
    }
}
