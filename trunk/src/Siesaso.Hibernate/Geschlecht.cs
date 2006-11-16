using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate
{
    /// <summary>
    /// Das geschlecht ist keine Entität, die über
    /// den Entity-Persister gespeichert wird. Ist auch
    /// eher unwahrscheinlich, dass Geschlechter hinzukommen.
    /// </summary>
    public class Geschlecht : Internal.Entity<Geschlecht>
    {
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
    }
}
