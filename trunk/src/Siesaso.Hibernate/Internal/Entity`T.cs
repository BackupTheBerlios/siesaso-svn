using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Hibernate.Internal
{
    /// <summary>
    /// Basisklasse f�r eine SieSaSo Entit�t. Es werden Funktionen f�r die
    /// Verwaltung der Entit�ten.
    /// </summary>
    /// <typeparam name="keytype">Jede Entit�t ist an eine Klasse (also den Typen gebunden)</typeparam>
    public abstract class Entity<keytype> : Entity
    {

        #region Abfragen

        /// <summary>
        /// Ermitteln einer Liste aller Objekte der Entit�ten.
        /// </summary>
        public static IList<keytype> List()
        {
            return Session.Instance.Get.CreateCriteria(typeof(keytype)).List<keytype>();
        }

        #endregion
    }
}
