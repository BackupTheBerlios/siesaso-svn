using System;
using System.Collections.Generic;
using System.Text;
using Excel;
using System.Windows.Forms;
using Softwarekueche.Siesaso.Hibernate;
using Dotnetuc.CsvMapper;

namespace Softwarekueche.Siesaso.Anmeldung2Csv
{
    class Program
    {
        static void Main(string[] args)
        {
            Internal.AnmeldungV4 av4 = new Internal.AnmeldungV4(System.Windows.Forms.Application.StartupPath + "\\" + "Meldung.xls");

            Console.WriteLine(av4.Verein.Name);

            foreach (Judoka jk in av4.Judoka)
            {
                Console.WriteLine(jk.Vorname + " " + jk.Nachname);
            }

            Console.ReadLine();

            List<Verein> vl = new List<Verein>();
            vl.Add(av4.Verein);

            CsvPersister<Verein> cpv = new CsvPersister<Verein>("verein.csv");
            cpv.Persist(vl);

            CsvPersister<Judoka> cpj = new CsvPersister<Judoka>("judoka.csv");
            cpj.Persist(av4.Judoka);
        }
    }
}
