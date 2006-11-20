using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate
{
    public class Turnier : Internal.Entity<Turnier>
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
        private String beschreibung;
        private DateTime datum;
        private DateTime datumReal;
        private String ausrichter;
        private String leitung;
        private String listenleitung;

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

        public virtual String Beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }

        public virtual DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public virtual DateTime DatumReal
        {
            get { return datumReal; }
            set { datumReal = value; }
        }

        public virtual String Ausrichter
        {
            get { return ausrichter; }
            set { ausrichter = value; }
        }

        public virtual String Leitung
        {
            get { return leitung; }
            set { leitung = value; }
        }

        public virtual String Listenleitung
        {
            get { return listenleitung; }
            set { listenleitung = value; }
        }

        #endregion

    }
}
