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
            if (zusatz == null || zusatz.ToString() == "") return vorname + " " + nachname;
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

        #region Pseudo Properties

        [CsvColumn("gürtel")]
        public virtual String GürtelString
        {
            get
            {
                return gürtel.Nummer.ToString();
            }
            set
            {
                foreach (Gürtel tst in Gürtel.List())
                {
                    if (tst.Nummer.ToString() == value.ToLower())
                    {
                        gürtel = tst;
                        return;
                    }
                }

                gürtel = null;
            }
        }

        [CsvColumn("verein")]
        public virtual String VereinString
        {
            get
            {
                return verein.Name;
            }
            set
            {
                Verein valueVerein = new Verein();
                valueVerein.Name = value;

                // Finden des Vereins nach HashNamen
                foreach (Verein tst in Verein.List())
                {
                    if (tst.GetNameHash() == valueVerein.GetNameHash())
                    {
                        verein = tst;
                        return;
                    }
                }
                verein = null;
            }
        }

        [CsvColumn("geschlecht")]
        public virtual String GeschlechtString
        {
            get
            {
                return geschlecht.Kurz;
            }
            set
            {
                foreach (Geschlecht tst in Geschlecht.List())
                {
                    if (tst.Kurz.ToLower() == value.ToLower())
                    {
                        geschlecht = tst;
                        return;
                    }
                }
                geschlecht = null;
            }
        }

        #endregion

        #region GetNameHash

        /// <summary>
        /// Typ zum benutzerdefinierten Zusammenfassen der Namen
        /// </summary>
        public enum HashType
        {
            /// <summary>Kein Ändern des String'</summary>
            None = 0,
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
        public virtual String GetNameHash(HashType typ)
        {
            String res = vorname;
            if (zusatz != null && zusatz.ToString() != "") res += " " + zusatz;
            res += " " + nachname;
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
