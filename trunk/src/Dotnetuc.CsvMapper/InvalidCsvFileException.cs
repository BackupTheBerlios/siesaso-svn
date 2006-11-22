using System;
using System.ComponentModel;
using System.Collections;

namespace Dotnetuc.CsvMapper
{
    /// <summary>
    /// Exception für eine ungültige CSV Datei.
    /// </summary>
    public class InvalidCsvFileException : System.Exception
    {

        public InvalidCsvFileException(string message)
            : base(message)
        {
        }

    }
}