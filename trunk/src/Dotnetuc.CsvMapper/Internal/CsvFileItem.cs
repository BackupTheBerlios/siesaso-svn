using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace Dotnetuc.CsvMapper.Internal
{

    /// <summary>
    /// Repräsentiert eine Datenzeile in einer CSV Datei. Zusätzlich werden die 
    /// Spaltenüberschriften gespeichert. Dadurch ist ein Zugriff über den 
    /// Index und den Spaltennamen möglich.
    /// </summary>
    public class CsvFileItem
    {

        /// <summary>
        /// Erstellt eine neue Datenzeile aus dem den übergebenen Spaltenheadern
        /// und der Daten.
        /// </summary>
        /// <param name="initData">Daten aus dem CsvFileReader.DataReader</param>
        /// <param name="initHeader">Spaltenüberschriften aus der CSV Datei</param>
        public CsvFileItem(object[] initData, string[] initHeader)
        {
            _data = initData;
            _header = initHeader;
        }

        /// <summary>
        /// Speichert die Daten
        /// </summary>
        private object[] _data;

        /// <summary>
        /// Speichert die Header
        /// </summary>
        private string[] _header;

        /// <summary>
        /// Gibt ein Datum aus den Daten zurück.
        /// </summary>
        /// <param name="index">Index des Feldes</param>
        public object Item(int index)
        {
            if (index >= _data.Length) return null;
            return _data[index];
        }

        /// <summary>
        /// Gibt ein Datum aus den Daten zurück.
        /// </summary>
        /// <param name="index">Spaltenüberschrift des Feldes</param>
        public object Item(string index)
        {
            int ind = Array.IndexOf(_header, index);
            if (ind == -1) throw new HeaderNotFoundException("Header not found");

            return Item(ind);
        }

    }
}

