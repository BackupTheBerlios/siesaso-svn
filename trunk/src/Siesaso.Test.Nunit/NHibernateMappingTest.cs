using System;
using System.Collections.Generic;
using System.Text;
using Softwarekueche.Siesaso.Hibernate;
using Softwarekueche.Siesaso.Hibernate.Internal;

namespace Softwarekueche.Siesaso.Test.Nunit
{
    [NUnit.Framework.TestFixture(Description="Tests für das NHibernate-Mapping")]
    class NHibernateMappingTest
    {

        [NUnit.Framework.Test(Description = "Abrufen aller Listen aus der Datenbank")]
        public void QueryListTest()
        {
            Siesaso.Hibernate.Internal.Session.InstanceDatabase = "SieSaSoDatenbank.mdb";

            IList<Gürtel> lstGu = Gürtel.List();
            IList<Geschlecht> lstGe = Geschlecht.List();
            IList<Judoka> lstJu = Judoka.List();
            IList<Kämpfer> lstKa = Kämpfer.List();
            IList<Klasse> lstKl = Klasse.List();
            IList<Trainer> lstTr = Trainer.List();
            IList<Turnier> lstTu = Turnier.List();
            IList<Verein> lstVr = Verein.List();
        }

        [NUnit.Framework.Test(Description = "Abrufen aller Trainer aus der Datenbank")]
        public void TrainerQueryItemTest()
        {
            Session.InstanceDatabase = "SieSaSoDatenbank.mdb";

            IList<Trainer> lstTr = Trainer.List();

            foreach (Trainer itm in lstTr)
            {
                Console.WriteLine(itm.ToString());
            }
        }

    }
}
