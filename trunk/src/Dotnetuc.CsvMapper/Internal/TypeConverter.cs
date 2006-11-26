using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.CsvMapper.Internal
{
    /// <summary>
    /// Klasse zum Konvertieren von Objekten in einen bestimmten Typ.
    /// </summary>
    class TypeConverter
    {
        public static Object Parse(Object src, Type to)
        {
            if (src == null) return Activator.CreateInstance(to);

            try
            {
                // Konvertierung versuchen
                if (to.FullName == "System.Int32")
                    return Int32.Parse(src.ToString());
                else if (to.FullName == "System.String")
                    return (src.ToString());
                else if (to.FullName == "System.DateTime")
                    return DateTime.Parse(src.ToString());
                else throw new NotImplementedException("Typ kann nicht konvertiert werden");
            }
            catch (Exception)
            {
                // Ansonsten eine Default-Instanz des Typed zurück geben
                return Activator.CreateInstance(to);
            }
        }
    }
}
