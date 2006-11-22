using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;
using Dotnetuc.CsvMapper;

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
            else return vorname + " '" + zusatz + "' " + nachname;
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

        [CsvColumn("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        [CsvColumn("vorname")]
        public virtual String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        [CsvColumn("nachname")]
        public virtual String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        [CsvColumn("zusatz")]
        public virtual String Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }

        [CsvColumn("geburtsdatum")]
        public virtual DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; }
        }

        [CsvColumn("gürtel")]
        public virtual Gürtel Gürtel
        {
            get { return gürtel; }
            set { gürtel = value; }
        }

        [CsvColumn("geschlecht")]
        public virtual Geschlecht Geschlecht
        {
            get { return geschlecht; }
            set { geschlecht = value; }
        }

        [CsvColumn("verein")]
        public virtual Verein Verein
        {
            get { return verein; }
            set { verein = value; }
        }

        #endregion

        #region GetNameHash

        /// <summary>
        /// Typ zum benutzerdefinierten Zusammenfassen der Namen
        /// </summary>
        public enum HashType
        {
            /// <summary>Zusammenfassen von d'' und 't'</summary>
            Sum_DT = 1,
            /// <summary>Zusammenfassen von doppelten Buchstaben</summary>
            Sum_Double = 2,
            /// <summary>Alle 'H' entfernen</summary>
            Sum_NoH = 4
        }

        /// <summary>
        /// Funktion zum Zusammenfassen des Namens in einen vergleichbaren String
        /// </summary>
        /// <param name="typ">Typ der Zusammenfassung</param>
        public String GetNameHash(HashType typ)
        {
            String res = vorname;
            if (zusatz != "") res += " " + zusatz;
            res += nachname;
            res = res.ToLower();

            if (res.Length == 0) return res;

            if ((typ & HashType.Sum_Double) == HashType.Sum_Double)
            {
                String res2 = res[0].ToString();
                char last = res[0];

                for (int i = 1; i < res.Length; i++)
                {
                    if (res[i] == last) continue;

                    res2 += res[i];
                    last = res[i];
                }
                res = res2;
            }

            if ((typ & HashType.Sum_DT) == HashType.Sum_DT)
            {
                res = res.Replace('d', 't');
            }

            if ((typ & HashType.Sum_NoH) == HashType.Sum_NoH)
            {
                res = res.Replace("h", "");
            }

            return res;
        }

        #endregion
    }
}
