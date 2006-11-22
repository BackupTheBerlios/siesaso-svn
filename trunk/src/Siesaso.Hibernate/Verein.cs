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
            return Langname;
        }

        #endregion

        #region Mapping

        private int id;
        private String name;
        private String langname;
        private String adresse;
        private String email;

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
        [CsvColumn("adresse")]
        public virtual String Adresse
        {
            get { return adresse; }
             set { adresse = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [CsvColumn("langname")]
        public virtual String Langname
        {
            get { return langname; }
            set { langname = value; }
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

    }
}
