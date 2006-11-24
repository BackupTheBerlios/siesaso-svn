using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.CsvMapper;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// 
    /// </summary>
    public class Trainer : Internal.Entity<Trainer>
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
        private String adresse;
        private String plzort;
        private String email;
        private String tel;
        private String fax;

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("tel")]
        public virtual String Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("fax")]
        public virtual String Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("email")]
        public virtual String Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("plzort")]
        public virtual String PlzOrt
        {
            get { return plzort; }
             set { plzort = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("adresse")]
        public virtual String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("name")]
        public virtual String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("id")]
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
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
            String res = name;
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
