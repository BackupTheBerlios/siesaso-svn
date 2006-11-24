using System;
using System.Collections.Generic;
using System.Text;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Anmeldung2Csv.Internal
{
    class AnmeldungV4 : IAnmeldung
    {

        private String fileName = null;

        private Verein verein = null;

        private List<Judoka> judoka = null;

        public AnmeldungV4(String initFileName)
        {
            fileName = initFileName;
            Generate();
        }

        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        #region Excel Hilfsfunktionen

        private String GetSheetValue(Excel.Worksheet worksheet, string field)
        {
            Excel.Range range = worksheet.get_Range(field, field);
            if (range == null) return "";
            if (range.Cells.Value2 == null) return "";
            return range.Cells.Value2.ToString();
        }

        private String GetJudokaCell(int rowNumber, String colChar)
        {
            String cell = colChar;
            cell = cell + (rowNumber + 19).ToString();
            return cell;
        }

        private bool HasSheetJudoka(int rowNumber, Excel.Worksheet worksheet)
        {
            String cell = GetJudokaCell(rowNumber, "B");
            String name = GetSheetValue(worksheet, cell);
            return name.CompareTo("") != 0;
        }

        #endregion

        public void Generate()
        {
            // Variablen initialisieren
            judoka = new List<Judoka>();
            verein = new Verein();

            // Ko-Kriterien
            if (!System.IO.File.Exists(fileName)) return;

            Excel.Application excel = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Worksheet Initialisieren
                excel = new Excel.Application();
                workbook = excel.Workbooks.Open(fileName, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, null, false, false, false);
                worksheet = (Excel.Worksheet)workbook.Sheets.get_Item(1);

                // Verein auslesen
                verein.Name = GetSheetValue(worksheet, "B2");
                verein.Kurzname = GetSheetValue(worksheet, "B2");
                verein.Email = GetSheetValue(worksheet, "B7");
                System.Text.StringBuilder sb = new StringBuilder();
                sb.AppendLine(GetSheetValue(worksheet, "B3"));
                sb.AppendLine(GetSheetValue(worksheet, "B4"));
                sb.AppendLine(GetSheetValue(worksheet, "B5"));
                sb.AppendLine(GetSheetValue(worksheet, "B6"));
                verein.Adresse = sb.ToString();

                // Kämpfer auslesen
                int counter = 1;
                while (HasSheetJudoka(counter, worksheet))
                {
                    Judoka j = new Judoka();
                    j.Vorname = GetSheetValue(worksheet, GetJudokaCell(counter, "C"));
                    j.Nachname = GetSheetValue(worksheet, GetJudokaCell(counter, "B"));
                    try
                    {
                        j.Geburtsdatum = DateTime.Parse(GetSheetValue(worksheet, GetJudokaCell(counter, "F")));
                    }
                    catch (Exception)
                    {
                        j.Geburtsdatum = new DateTime(1900,1,1);
                    }

                    j.Gürtel = new Gürtel(GetSheetValue(worksheet, GetJudokaCell(counter, "D")), "9");
                    j.Geschlecht = new Geschlecht(GetSheetValue(worksheet, GetJudokaCell(counter, "E")));
                    j.Verein = verein;

                    judoka.Add(j);
                    counter++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Excel beenden
                workbook.Close(false, null, 0);
                workbook = null;
                excel.Quit();
                excel = null;
                System.GC.WaitForPendingFinalizers();
            }
        }

        #region IAnmeldung Members

        public Softwarekueche.Siesaso.Hibernate.Verein Verein
        {
            get { return verein; }
        }

        public List<Softwarekueche.Siesaso.Hibernate.Judoka> Judoka
        {
            get { return judoka; }
        }

        #endregion
    }
}
