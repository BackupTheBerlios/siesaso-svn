using System;
using System.Collections.Generic;
using System.Text;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Anmeldung2Csv.Internal
{
    interface IAnmeldung
    {
        Verein Verein { get; }

        List<Judoka> Judoka { get; }
    }
}
