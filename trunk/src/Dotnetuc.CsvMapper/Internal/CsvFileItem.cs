using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace Dotnetuc.CsvMapper.Internal
{

    /// <summary>
    /// Repr�sentiert eine Datenzeile in einer CSV Datei. Zus�tzlich werden die 
    /// Spalten�berschriften gespeichert. Dadurch ist ein Zugriff �ber den 
    /// Index und den Spaltennamen m�glich.
    /// </summary>
    public class CsvFileItem
    {

        /// <summary>
        /// Erstellt eine neue Datenzeile aus dem den �bergebenen Spaltenheadern
        /// und der Daten.
        /// </summary>
        /// <param name="initData">Daten aus dem CsvFileReader.DataReader</param>
        /// <param name="initHeader">Spalten�berschriften aus der CSV Datei</param>
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
        /// Gibt ein Datum aus den Daten zur�ck.
        /// </summary>
        /// <param name="index">Index des Feldes</param>
        public object Item(int index)
        {
            if (index >= _data.Length) return null;
            return _data[index];
        }

        /// <summary>
        /// Gibt ein Datum aus den Daten zur�ck.
        /// </summary>
        /// <param name="index">Spalten�berschrift des Feldes</param>
        public object Item(string index)
        {
            int ind = Array.IndexOf(_header, index);
            if (ind == -1) throw new HeaderNotFoundException("Header not found");

            return Item(ind);
        }

    }
}

