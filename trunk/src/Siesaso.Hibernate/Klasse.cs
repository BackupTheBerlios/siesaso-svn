using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// Entität für eine Wettkampfklasse
    /// </summary>
    public class Klasse : Internal.Entity<Klasse>
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

        private String langname;

        private int maxAlter;

        private double maxGewicht;

        private Geschlecht geschlecht;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual String Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual String Langname
        {
            get { return langname; }
            set { langname = value; }
        }

        public virtual int MaxAlter
        {
            get { return maxAlter; }
            set { maxAlter = value; }
        }

        public virtual double MaxGewicht
        {
            get { return maxGewicht; }
            set { maxGewicht = value; }
        }

        public virtual Geschlecht Geschlecht
        {
            get { return geschlecht; }
            set { geschlecht = value; }
        }

        #endregion
    }
}
