using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Dotnetuc.CsvMapper.Internal
{

	/// <summary>
	/// Der CvsFileWriter ist eine Klasse zum zeilenweisen Schreiben von CVS Dateien. Die
	/// CVS Dateien enthalten in der ersten Zeile die Spaltenüberschriften.
	/// </summary>
	public class CsvNativeWriter
	{
        #region Logger

        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

		/// <summary>
		/// Erstellt einen neuen CsvFileReader auf der Basis der übergebenen CSV Datei.
		/// </summary>
		/// <param name="initFileName">CVS Datei, auf der die Instanz basiert</param>
		public CsvNativeWriter(string initFileName)
		{
			fileName = initFileName;
			header = "";
			body = new List<string>();
			currentItem = "";
		}

		/// <summary>
		/// Speichert den Namen der CSV Datei
		/// </summary>
		private string fileName;

		/// <summary>
		/// Gibt den Namen der CSV Datei zurück.
		/// </summary>
		/// <value>Name der CSV Datei</value>
		/// <returns>Name der CSV Datei</returns>
		public string FileName {
			get { return fileName; }
		}

		/// <summary>
		/// Variable mit der Kopfzeile
		/// </summary>
		private string header;

		/// <summary>
		/// CSV Datenzeilen
		/// </summary>
		private List<string> body;

		public void WriteHeader(string column)
		{
			if (header.Length == 0)
			{
				// Erster Header
				header = "\"" + column + "\"";
			}
			else
			{
				// Weiterer Header
                header += ";\"" + column + "\"";
			}
		}

		public void WriteItem()
		{
			body.Add(currentItem);
			currentItem = "";
		}

		private string currentItem;

		public void WriteField(object value, Type type)
		{
            if (currentItem.Length > 0) currentItem += ";";

			if (object.ReferenceEquals(type, typeof(int)) || 
                object.ReferenceEquals(type, typeof(short)) || 
                object.ReferenceEquals(type, typeof(long)))
			{
				// Wert ohne Hochkommas
				if (value == null)
				{
                    currentItem += "0";
				}
				else
				{
                    currentItem += value.ToString();
				}
			}
			else
			{
				// Wert mit Hochkommas
				if (value == null)
				{
                    currentItem += ";\"\"";
				}
				else
				{
                    currentItem += ";\"" + value.ToString() + "\"";
				}
			}

		}

		private System.Text.Encoding _encoding = new System.Text.UTF8Encoding();

		public System.Text.Encoding Encoding {
			get { return _encoding; }
			set { _encoding = value; }
		}

		public void Flush()
		{
			// CSV Datei öffnen
			StreamWriter s = new StreamWriter(fileName, false, _encoding);
			// Header schreiben
			s.WriteLine(header);
			// Body schreiben
			foreach (string str in body) {
				s.WriteLine(str);
			}
			// Datei schließen
			s.Close();
		}

	}
}

