using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Dotnetuc.CsvMapper.Internal
{

	public class CsvNativeReader : IEnumerable<CsvFileItem>, IEnumerator<CsvFileItem>, IDisposable
	{
        #region Logger

        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

		#region Member

		private string fileName;

		private List<CsvHeaderInfo> header;

		private string[] headerArray;

		private System.Text.Encoding encoding = new System.Text.UTF8Encoding();

        private StreamReader csvFile = null; 

		#endregion

        #region Konstruktor

        public CsvNativeReader(string initFileName)
		{
			FileInfo fi = new FileInfo(initFileName);
			if (!fi.Exists) throw new FileNotFoundException("Datei " + initFileName + " existiert nicht"); 

			fileName = initFileName;
			ReadHeader();
        }

        #endregion

        #region Header

        private void ReadHeader()
		{
			header = new List<CsvHeaderInfo>();

			StreamReader s = new StreamReader(fileName, encoding);
			// Header lesen
			string tmpHdr = s.ReadLine();
			if (tmpHdr == null) return; // TODO: might not be correct. Was : Exit Sub


            string[] tmpHdrs = tmpHdr.Split(new String[] { ("\",\"") }, StringSplitOptions.None);

			headerArray = tmpHdrs;

			for (int i = 0; i <= tmpHdrs.Length - 1; i++) {
				header.Add(new CsvHeaderInfo(i, tmpHdrs[i]));
			}

		}

		public IList Header {
			get { return header; }
        }

        #endregion

        #region FileName / Encoding

        public String FileName {
			get { return fileName; }
		}

		public System.Text.Encoding Encoding {
			get { return encoding; }
			set { encoding = value; }
        }

        #endregion


        #region IEnumerator<CsvFileItem> Members

        CsvFileItem IEnumerator<CsvFileItem>.Current
        {
            get 
            {
                header = new List<CsvHeaderInfo>();
                string tmpLne = csvFile.ReadLine();
                string[] tmpLnes = tmpLne.Split(new String[] { ("\",\"") }, StringSplitOptions.None);

                return new CsvFileItem(tmpLnes, headerArray);
   
            }
        }

        #endregion

        #region IEnumerator Members

        object IEnumerator.Current
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        bool IEnumerator.MoveNext()
        {
            if (!File.Exists(fileName)) return false;

            try
            {
                if (csvFile == null)
                {
                    csvFile = new StreamReader(fileName, encoding);
                    csvFile.ReadLine();
                    // Header weglesen
                }
                return !csvFile.EndOfStream;
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled) log.Error("Fehler bei MoveNext", ex);
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            if ((csvFile != null)) csvFile.Close();
            csvFile = null;
        }

        #endregion


        #region IEnumerable<CsvFileItem> Members

        IEnumerator<CsvFileItem> IEnumerable<CsvFileItem>.GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        #endregion


		#region IDisposable implementierung

			// To detect redundant calls
		private bool disposedValue = false;

		// IDisposable
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
                    if ((csvFile != null)) csvFile.Close(); 
					// TODO: free unmanaged resources when explicitly called
				}

				// TODO: free shared unmanaged resources
			}
			this.disposedValue = true;
		}

		// This code added by Visual Basic to correctly implement the disposable pattern.
		void IDisposable.Dispose()
		{
			// Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion

    }
}

