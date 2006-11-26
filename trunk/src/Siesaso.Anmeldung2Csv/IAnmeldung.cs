using System;
using System.Collections.Generic;
using System.Text;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Anmeldung2Csv
{
    public interface IAnmeldung
    {
        Verein Verein { get; }

        Trainer Trainer { get; }

        List<Judoka> Judoka { get; }
    }
}
