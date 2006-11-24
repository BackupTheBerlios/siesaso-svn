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
            foreach (string arg in args)
            {
                Console.WriteLine("Datei: " + arg);
                if (!System.IO.File.Exists(arg)) continue;

                System.IO.FileInfo fi = new System.IO.FileInfo(arg);

                Internal.AnmeldungV4 av4 = new Internal.AnmeldungV4(fi.FullName);

                Console.WriteLine(av4.Verein.Name + "  -> " + av4.Verein.GetNameHash());

                foreach (Judoka jk in av4.Judoka)
                {
                    Console.Write(jk.Vorname + " " + jk.Nachname);
                    Console.WriteLine("  -> " + jk.GetNameHash(Judoka.HashType.Sum_Double | Judoka.HashType.Sum_DT));
                }

                List<Verein> vl = new List<Verein>();
                vl.Add(av4.Verein);

                CsvPersister<Verein> cpv = new CsvPersister<Verein>(fi.Directory + "\\" + av4.Verein.GetNameHash() + "_verein.csv");
                cpv.Persist(vl);
                Console.WriteLine("Ausgabe Verein: " + cpv.CsvFile);

                CsvPersister<Judoka> cpj = new CsvPersister<Judoka>(fi.Directory + "\\" + av4.Verein.GetNameHash() + "_judoka.csv");
                cpj.Persist(av4.Judoka);
                Console.WriteLine("Ausgabe Judoka: " + cpj.CsvFile);
            }
        }
    }
}
