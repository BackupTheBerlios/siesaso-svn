
namespace Dotnetuc.CsvMapper.Internal
{

	/// <summary>
	/// Klasse zum Beschreiben von Informationen �ber die gemappten
	/// Eigenschaften der Fachklasse. Daf�r wird zum einen eine
	/// <see cref="Reflection.PropertyInfo">PropertyInfo</see> 
	/// und das gefundene <see cref="CsvAttribute">CsvAttribut</see> 
	/// gespeichert.
	/// </summary>
	public class CsvFieldInfo
	{

		/// <summary>
		/// Erstellt eine neue Instanz f�r eine gefundene Eigenschaft
		/// </summary>
		/// <param name="initCsvAttribute">CsvAttribut, dass in der Klasse angegeben wurde</param>
		/// <param name="initPropertyInfo">PropertyInfo f�r die Eigenschaft der Klasse</param>
		public CsvFieldInfo(CsvColumnAttribute initCsvAttribute, System.Reflection.PropertyInfo initPropertyInfo) : base()
		{

            csvColumnAttribute = initCsvAttribute;
			propertyInfo = initPropertyInfo;
		}

		/// <summary>
		/// Speichert das CsvAttribut
		/// </summary>
        private CsvColumnAttribute csvColumnAttribute;

		/// <summary>
		/// Speichert die PropertyInfo
		/// </summary>
		private System.Reflection.PropertyInfo propertyInfo;

		/// <summary>
		/// Gibt das CsvAttribut mit dem Namen der Spalte in der CSV Datei zur�ck.
		/// </summary>
		/// <value>CsvAttribute der Eigenschaft</value>
		/// <returns>CsvAttribute der Eigenschaft</returns>
		public CsvColumnAttribute CsvAttribute {
			get { return csvColumnAttribute; }
		}

		/// <summary>
		/// Gibt die PropertyInfo f�r die Eigenschaft des Objektes zur�ck.
		/// </summary>
		/// <value>PropertyInfo des Objektes</value>
		/// <returns>PropertyInfo des Objektes</returns>
		public System.Reflection.PropertyInfo PropertyInfo {
			get { return propertyInfo; }
		}

	}

}
