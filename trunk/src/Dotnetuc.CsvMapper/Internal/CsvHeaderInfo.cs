
namespace Dotnetuc.CsvMapper.Internal
{

	/// <summary>
	/// Speichert die CSV Spaltenüberschriften mit den zugehörigen Index.
	/// </summary>
	public class CsvHeaderInfo
	{

		/// <summary>
		/// Legt eine neue Spaltenüberschrift mit Namen und Index an.
		/// </summary>
		/// <param name="initIndex">Index der Überschrift</param>
		/// <param name="initHeader">Name der Überschrift</param>
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
		/// Speichert den Namen der Spaltenüberschrift.
		/// </summary>
		private string _header;

	}
}

