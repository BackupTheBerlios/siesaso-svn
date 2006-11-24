using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// Das Geschlecht ist eine Entit�t, deren Prim�rschl�ssel ein
    /// String mit der L�nge "1".
    /// </summary>
    public class Geschlecht : Internal.Entity<Geschlecht>
    {
        #region �berschreibungen

        public override String ToString()
        {
            return lang;
        }

        #endregion

        #region Konstruktoren 

        public Geschlecht()
            : base()
        {
        }

        public Geschlecht(String geschlecht)
            : this()
        {
            if (geschlecht.ToLower() == "m")
            {
                kurz = "m";
                lang = "m�nnlich";

            }
            else if (geschlecht.ToLower() == "w")
            {
                kurz = "w";
                lang = "weiblich";
            }
            else
            {
                kurz = "x";
                lang = "unbekannt";
            }
        }

        #endregion

        #region Mapping

        private String kurz;

        private String lang;

        public virtual String Kurz
        {
            get { return kurz; }
            set { kurz = value; }
        }

        public virtual String Lang
        {
            get { return lang; }
            set { lang = value; }
        }

        protected override int PrimaryKey()
        {
            if (kurz == "") return 0;
            return -1;
        }

        #endregion
    }
}
