using System;
using System.ComponentModel;
using System.Collections;

namespace Dotnetuc.CsvMapper
{
    /// <summary>
    /// Eine HeaderNotFoundException ist eine <see cref="System.Exception">Exception</see>.
    /// Der Fehler wird ausgelöst, wenn eine Spalte in der CVS Datei nicht gefunden werden kann,
    /// obwohl diese im Objekt angegeben wurde.
    /// </summary>
    /// <remarks>
    /// Die Fehlermeldung kann im <see cref="CsvMapper(Of T)">CsvMapper</see>
    /// mit der Eigenschaft "IgnoreErrors" unterdrückt werden.
    /// </remarks>
    public class HeaderNotFoundException : System.Exception
    {

        /// <summary>
        /// Erzeugt eine neue Fehlermeldung mit der angegebenen Fehlermeldung.
        /// </summary>
        /// <param name="message">Fehlermeldung</param>
        public HeaderNotFoundException(string message)
            : base(message)
        {
        }

    }

}