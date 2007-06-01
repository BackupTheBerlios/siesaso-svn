﻿using System;
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

        #region Konstruktoren

        public Gürtel()
            : base()
        {
        }

        /// <summary>
        /// Erzeugen eines neuen Gürtels auf des Basis der Gürtelnummer.
        /// </summary>
        /// <param name="gürtel"></param>
        /// <param name="def"></param>
        public Gürtel(String gürtel, String def)
            : this()
        {
            if (gürtel == "") gürtel = def; //Default Gürtel

            int gürtelNummer = 0;
            if (int.TryParse(gürtel, out gürtelNummer) && gürtelNummer != 0)
            {
                this.nummer = gürtelNummer;
            }
            else
            {
                this.nummer = 0;
            }
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
