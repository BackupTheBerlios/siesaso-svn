using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate
{
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

        public virtual String Email
        {
            get { return email; }
            set { email = value; }
        }

        public virtual String Adresse
        {
            get { return adresse; }
             set { adresse = value; }
        }

        public virtual String Langname
        {
            get { return langname; }
            set { langname = value; }
        }

        public virtual String Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

    }
}
