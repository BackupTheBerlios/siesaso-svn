using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.CsvMapper;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// 
    /// </summary>
    public class Verein : Internal.Entity<Verein>
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
        private String kurzname;
        private String adresse;
        private String plzort;
        private String email;
        private String tel;
        private String fax;
        private String nameAlternativ;

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("nameAlternativ")]
        public virtual String NameAlternativ
        {
            get { return nameAlternativ; }
            set { nameAlternativ = value; }
        }

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
        [CsvColumn("kurzname")]
        public virtual String Kurzname
        {
            get { return kurzname; }
            set { kurzname = value; }
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

        #region GetHashName

        public virtual String GetNameHash()
        {
            String res = name.ToLower();
            String res2 = "";

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] >= 'a' && res[i] < 'z') res2 = res2 + res[i].ToString();
            }

            return res2;
        }

        public virtual String GetKurzNameHash()
        {
            String res = kurzname.ToLower();
            String res2 = "";

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] >= 'a' && res[i] < 'z') res2 = res2 + res[i].ToString();
            }

            return res2;
        }

        #endregion

    }
}
