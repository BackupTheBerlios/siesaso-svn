using System;
using System.ComponentModel;
using System.Collections;

namespace Dotnetuc.CsvMapper
{
    /// <summary>
    /// Exception f�r eine ung�ltige CSV Datei.
    /// </summary>
    public class InvalidCsvFileException : System.Exception
    {

        public InvalidCsvFileException(string message)
            : base(message)
        {
        }

    }
}