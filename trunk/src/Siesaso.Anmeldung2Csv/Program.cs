using System;
using System.Collections.Generic;
using System.Text;
using Excel;
using System.Windows.Forms;
using System.IO;
using Softwarekueche.Siesaso.Hibernate;
using Dotnetuc.CsvMapper;

namespace Softwarekueche.Siesaso.Anmeldung2Csv
{
    class Program
    {
        static int Main(string[] args)
        {
            foreach (string arg in args)
            {
                FileInfo fi = new FileInfo(arg);
                Console.WriteLine("Verzeichnis: " + fi.DirectoryName);
                Console.WriteLine("Datei: " + fi.Name);
                if (!fi.Exists) continue;
                if (fi.Extension.CompareTo(".xls") != 0) continue;

                Console.WriteLine();

                // Todo mentzel Proxy zum Generieren der richtigen Instanz (v4, v3 ...)
                IAnmeldung av4 = new Internal.AnmeldungV4(fi.FullName);

                Console.WriteLine(av4.Verein.Name + "  -> " + av4.Verein.GetNameHash());

                foreach (Judoka jk in av4.Judoka)
                {
                    Console.Write("    " + jk.Vorname + " " + jk.Nachname);
                    Console.WriteLine("  -> " + jk.GetNameHash(Judoka.HashType.Sum_Double | Judoka.HashType.Sum_DT));
                }

                List<Verein> vl = new List<Verein>();
                vl.Add(av4.Verein);

                List<Trainer> vt = new List<Trainer>();
                vt.Add(av4.Trainer);

                Console.WriteLine();

                CsvPersister<Verein> cpv = new CsvPersister<Verein>(fi.Directory + "\\" + av4.Verein.GetNameHash() + ".verein.csv");
                cpv.Persist(vl);
                Console.WriteLine("Ausgabe Verein: " + cpv.CsvFile.Substring(fi.DirectoryName.Length+1));

                CsvPersister<Trainer> cpt = new CsvPersister<Trainer>(fi.Directory + "\\" + av4.Verein.GetNameHash() + ".trainer.csv");
                cpt.Persist(vt);
                Console.WriteLine("Ausgabe Trainer: " + cpt.CsvFile.Substring(fi.DirectoryName.Length + 1));

                CsvPersister<Judoka> cpj = new CsvPersister<Judoka>(fi.Directory + "\\" + av4.Verein.GetNameHash() + ".judoka.csv");
                cpj.Persist(av4.Judoka);
                Console.WriteLine("Ausgabe Judoka: " + cpj.CsvFile.Substring(fi.DirectoryName.Length + 1));

                Console.WriteLine();
            }

            Console.ReadLine();
            return 0;
        }
    }
}
