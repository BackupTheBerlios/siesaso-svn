using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Siesaso.Hibernate
{
    /// <summary>
    /// Basisklasse mit den Abstrakten nicht-generischen Funktionen aller
    /// Entitäten. Es werden die Grundfunktionalitäten zum Verwalten der
    /// Klassen bereit gestellt.
    /// </summary>
    public abstract class Entity : IEntity
    {

        /// <summary>
        /// Funktion, die für die Entitäten den Primärschlüssel zurück gibt. Da das Feld
        /// der Entitäten hier nicht bekannt ist, muss es als Abstract definiert werden.
        /// </summary>
        /// <returns>Primärschlüssel der Entität</returns>
        protected abstract int PrimaryKey();

        #region IEntity Members

        /// <summary>
        /// Löscht das Objekt aus Hibernate / der Datenbank
        /// </summary>
        public virtual void Delete()
        {
            if (this.IsUnsaved) return; //Nicht in Hibernate gespeichert

            Session.Instance.Get.Delete(this);
            Session.Instance.Get.Flush();
        }

        /// <summary>
        /// Speichert das Objekt in Hibernate / der Datenbank
        /// </summary>
        public virtual void Save()
        {
            Session.Instance.Get.SaveOrUpdate(this);
            Session.Instance.Get.Flush();
        }

        /// <summary>
        /// Funktion die Ermittelt, ob die Entität bereits gespeichert wurde
        /// </summary>
        public bool IsUnsaved
        {
            get
            {
                return PrimaryKey() == 0;
            }
        }

        #endregion
    }
}
