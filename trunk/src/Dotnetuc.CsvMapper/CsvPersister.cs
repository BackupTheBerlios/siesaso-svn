using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
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
    public class CsvPersister<keyType>
    {
        #region Logger

        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        /// <summary>
        /// Erstellt eine neue Instanz und analysiert den KeyType.
        /// </summary>
        public CsvPersister()
            : base()
        {

            // Initialisieren der Felder der Klasse
            readFieldInfo();
        }

        /// <summary>
        /// Erstellt eine neue Instanz und analysiert den KeyType.
        /// </summary>
        /// <param name="initCsvFile">CSV Datei, welche die Daten enthält.</param>
        public CsvPersister(string initCsvFile)
            : this()
        {

            CsvFile = initCsvFile;
        }

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
            _fieldInfos = new List<CsvFieldInfo>();
            System.Reflection.PropertyInfo[] pis;
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
                        if (cfi.CsvAttribute.Persist) _fieldInfos.Add(cfi);
                    }

                }

            }

        }

        private List<CsvFieldInfo> _fieldInfos;

        private CsvNativeWriter _csvFileWriter;

        /// <summary>
        /// Name der CSV Datei
        /// </summary>
        public string CsvFile
        {
            get { return _csvFileWriter.FileName; }
            set
            {
                _csvFileWriter = new CsvNativeWriter(value);
                _csvFileWriter.Encoding = this._encoding;
            }
        }

        private System.Text.Encoding _encoding = new System.Text.UTF8Encoding();

        public System.Text.Encoding Encoding
        {
            get { return _encoding; }
            set
            {
                _encoding = value;
                if ((_csvFileWriter != null)) _csvFileWriter.Encoding = _encoding;
            }
        }

        /// <summary>
        /// Persistiert eine Liste von Fachobjekten.
        /// </summary>
        public void Persist(IList<keyType> list)
        {
            if (_csvFileWriter == null) throw new InvalidCsvFileException("Keine CSV Datei angegeben");

            foreach (CsvFieldInfo cfi in _fieldInfos)
            {
                if (!cfi.CsvAttribute.Persist) continue;

                _csvFileWriter.WriteHeader(cfi.CsvAttribute.csvColumn);
            }

            foreach (keyType t in list)
            {
                if (t == null) continue;

                foreach (CsvFieldInfo cfi in _fieldInfos)
                {
                    if (!cfi.CsvAttribute.Persist) continue;

                    object value;

                    value = cfi.PropertyInfo.GetValue(t, null);

                    _csvFileWriter.WriteField(value, cfi.PropertyInfo.PropertyType);

                }

                _csvFileWriter.WriteItem();

            }

            _csvFileWriter.Flush();

        }
    }
}