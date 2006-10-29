using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Hibernate
{
    /// <summary>
    /// Basisklasse für eine SieSaSo Entität. Es werden Funktionen für die
    /// Verwaltung der Entitäten.
    /// </summary>
    /// <typeparam name="keytype">Jede Entität ist an eine Klasse (also den Typen gebunden)</typeparam>
    public class Entity<keytype> : Entity
    {
        /// <summary>
        /// Ermitteln einer Liste aller Objekte der Entitäten.
        /// </summary>
        public static IList<keytype> List()
        {
            return Session.Instance.Get.CreateCriteria(typeof(keytype)).List<keytype>();
        }
    }
}
