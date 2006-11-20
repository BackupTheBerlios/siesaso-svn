using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate
{
    public class Kämpfer : Internal.Entity<Kämpfer>
    {
        #region Überschreibungen

        protected override int PrimaryKey()
        {
            return id;
        }

        public override string ToString()
        {
            if (judoka != null) return judoka.ToString();
            return "Judoka nicht zugeordnet";
        }

        #endregion

        #region Mapping

        private int id;
        private double gewicht;
        private int punkte;
        private int punkteReal;
        private Judoka judoka;
        private Turnier turnier;
        private Klasse klasse;
        private Klasse klasseReal;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual double Gewicht
        {
            get { return gewicht; }
             set { gewicht = value; }
        }

        public virtual int Punkte
        {
            get { return punkte; }
            set { punkte = value; }
        }

        public virtual int PunkteReal
        {
            get { return punkteReal; }
            set { punkteReal = value; }
        }

        public virtual Judoka Judoka
        {
            get { return judoka; }
            set { judoka = value; }
        }

        public virtual Turnier Turnier
        {
            get { return turnier; }
            set { turnier = value; }
        }

        public virtual Klasse Klasse
        {
            get { return klasse; }
            set { klasse = value; }
        }

        public virtual Klasse KlasseReal
        {
            get { return klasseReal; }
            set { klasseReal = value; }
        }

        #endregion

    }
}
