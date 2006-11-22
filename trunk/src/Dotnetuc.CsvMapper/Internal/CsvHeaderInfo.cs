
namespace Dotnetuc.CsvMapper.Internal
{

	/// <summary>
	/// Speichert die CSV Spalten�berschriften mit den zugeh�rigen Index.
	/// </summary>
	public class CsvHeaderInfo
	{

		/// <summary>
		/// Legt eine neue Spalten�berschrift mit Namen und Index an.
		/// </summary>
		/// <param name="initIndex">Index der �berschrift</param>
		/// <param name="initHeader">Name der �berschrift</param>
		public CsvHeaderInfo(int initIndex, string initHeader)
		{
			_index = initIndex;
			_header = initHeader;
		}

		/// <summary>
		/// Speichert den Index
		/// </summary>
		private int _index;

		/// <summary>
		/// Speichert den Namen der Spalten�berschrift.
		/// </summary>
		private string _header;

	}
}

