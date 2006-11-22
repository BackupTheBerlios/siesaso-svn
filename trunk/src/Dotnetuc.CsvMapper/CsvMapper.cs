using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Dotnetuc.CsvMapper.Internal;

namespace Dotnetuc.CsvMapper
{
    /// <summary>
    /// Die Klasse CsvMapper ist die Klasse zum Anlegen von Objekten auf der Basis
    /// einer CSV Datei. Dazu wird als Typ die Klasse angegeben, welche die
    /// <see cref="CsvAttribute">CsvAttribute enthält.</see>
    /// Beim Anlegen einer Klasse wird das Fachobjekt analysiert und die 
    /// Mapping-Informationen des Fachobjektes.
    /// <code>
    /// Dim cm As New CsvMapper(Of AttrKlasse)("Test.csv")
    /// Dim lst As IList = cm.List
    /// 
    /// For Each o As AttrKlasse In lst
    ///     Debug.WriteLine(o.ToString())
    /// Next
    /// </code>
    /// </summary>
    /// <typeparam name="keyType">Typ, von dem eine Liste von Objekten aus der 
    /// CSV Datei erzeugt werden soll.</typeparam>
    public class CsvMapper<keyType>
    {
        #region Logger

        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Konstruktor

        /// <summary>
        /// Erstellt eine neue Instanz und analysiert den KeyType.
        /// </summary>
        public CsvMapper()
            : base()
        {

            // Initialisieren der Felder der Klasse
            readFieldInfo();
        }

        /// <summary>
        /// Erstellt eine neue Instanz und analysiert den KeyType.
        /// </summary>
        /// <param name="initCsvFile">CSV Datei, welche die Daten enthält.</param>
        public CsvMapper(string initCsvFile)
            : this()
        {

            CsvFile = initCsvFile;
        }

        #endregion

        /// <summary>
        /// Speichert den Wert von IgnoreErrors
        /// </summary>
        private bool _ignoreErrors = false;

        /// <summary>
        /// Gibt an, ob Mapping-Fehler zu einer Exception führen
        /// </summary>
        public bool IgnoreErrors
        {
            get { return _ignoreErrors; }
            set { _ignoreErrors = value; }
        }

        /// <summary>
        /// Liest aus der Fachklasse die CsvAttrubute
        /// </summary>
        private void readFieldInfo()
        {
            // Initialisieren der Felder
            fieldInfos = new List<CsvFieldInfo>();
            PropertyInfo[] pis;
            object[] cas;
            CsvFieldInfo cfi;

            // Auslesen der Properties
            pis = typeof(keyType).GetProperties();

            foreach (System.Reflection.PropertyInfo pi in pis)
            {

                // Auslesen der Attribute
                cas = pi.GetCustomAttributes(true);

                foreach (object ca in cas)
                {

                    // CsvAttribute der FieldInfo-Liste hinzufügen
                    if (ca is CsvColumnAttribute)
                    {
                        cfi = new CsvFieldInfo((CsvColumnAttribute)ca, pi);
                        if (cfi.CsvAttribute.Map) fieldInfos.Add(cfi);
                    }

                }

            }

        }

        private List<CsvFieldInfo> fieldInfos;

        private CsvNativeReader csvFileReader;

        /// <summary>
        /// Name der CSV Datei
        /// </summary>
        public string CsvFile
        {
            get { return csvFileReader.FileName; }
            set { csvFileReader = new CsvNativeReader(value); }
        }

        /// <summary>
        /// Erzeugt eine Liste von Fachobjekten und gibt diese zurück.
        /// </summary>
        public List<keyType> List()
        {
            List<keyType> res = new List<keyType>();
            keyType tmp;
            object val;
            CsvFileItem cur;

            IEnumerator<CsvFileItem> en = ((IEnumerable<CsvFileItem>)csvFileReader).GetEnumerator();

            while (en.MoveNext())
            {
                tmp = (keyType)Activator.CreateInstance(typeof(keyType));

                cur = (CsvFileItem)en.Current;

                foreach (CsvFieldInfo cfi in this.fieldInfos)
                {
                    if (!cfi.CsvAttribute.Map) continue;

                    try
                    {
                        val = cur.Item(cfi.CsvAttribute.csvColumn);
                    }
                    catch (Exception ex)
                    {
                        if (log.IsErrorEnabled) log.Error("Fehler beim Generieren der Liste aufgetreten", ex);
                        if (!this.IgnoreErrors) throw;
                        val = null;
                    }

                    cfi.PropertyInfo.SetValue(tmp, val, BindingFlags.Public | BindingFlags.SetField | BindingFlags.Instance, null, null, CultureInfo.CurrentCulture);
                }

                res.Add(tmp);
            }

            en.Reset();

            return res;
        }

    }

}