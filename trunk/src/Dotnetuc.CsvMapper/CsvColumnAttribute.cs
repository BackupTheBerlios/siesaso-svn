using System;
using System.ComponentModel;
using System.Collections;

namespace Dotnetuc.CsvMapper
{
    /// <summary>
    /// Attribut zum Beschreiben des Mappings der CSV Spalten auf das Objekt.
    /// <code>
    ///&lt;CsvColumn("AlterSpalte")&gt; _ <br />
    ///Public Property Alter() As Integer<br />
    ///    Get<br />
    ///        Return _alter<br />
    ///    End Get<br />
    ///    Set(ByVal value As Integer)<br />
    ///        _alter = value<br />
    ///    End Set<br />
    ///End Property
    /// </code>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class CsvColumnAttribute : System.Attribute
    {

        /// <summary>
        /// Legt eine neue Instanz eines CSV Attributes mit der CSV Spalteninformation
        /// an.
        /// </summary>
        /// <param name="csvColumn">Name der CSV Spalte</param>
        public CsvColumnAttribute(string csvColumn)
        {
            _csvColumn = csvColumn;
        }

        /// <summary>
        /// Hält den Wert für die Eigenschaft <see cref="csvColumn">CsvColumn</see>
        /// </summary>
        /// <remarks></remarks>
        private string _csvColumn;

        /// <summary>
        /// Name der Spalte in der CSV Datei, mit dessen Wert die Eigenschaft des Objetkes
        /// initialisiert wird.
        /// </summary>
        /// <value>Name der CSV Spalte</value>
        /// <returns>Name der CSV Spalte</returns>
        /// <remarks>Es wird ein <see cref="HeaderNotFoundException">Fehler</see> geworfen,
        /// wenn in der CSV Datei die Spalte nicht gefunden werden kann.</remarks>
        public string csvColumn
        {
            get { return _csvColumn; }
        }

        #region " Eigenschaft Persist As Boolean = True "

        /// <summary>
        /// Speichert den Wert für die Eigenschaft Persist.
        /// Default ist True
        /// </summary>
        private bool _Persist = true;

        /// <summary>
        /// Eigenschaft Persist
        /// </summary>
        public bool Persist
        {
            get { return (this._Persist); }
            set { this._Persist = value; }
        }

        #endregion

        #region " Eigenschaft Map As Boolean = True "

        /// <summary>
        /// Speichert den Wert für die Eigenschaft Map.
        /// Default ist True
        /// </summary>
        private bool _Map = true;

        /// <summary>
        /// Eigenschaft Map
        /// </summary>
        public bool Map
        {
            get { return (this._Map); }
            set { this._Map = value; }
        }

        #endregion

    }

}