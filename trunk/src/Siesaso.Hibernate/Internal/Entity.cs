using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.NHibernate;

namespace Softwarekueche.Siesaso.Hibernate.Internal
{
    /// <summary>
    /// Basisklasse mit den Abstrakten nicht-generischen Funktionen aller
    /// Entit�ten. Es werden die Grundfunktionalit�ten zum Verwalten der
    /// Klassen bereit gestellt.
    /// </summary>
    public abstract class Entity : IEntity
    {

        /// <summary>
        /// Funktion, die f�r die Entit�ten den Prim�rschl�ssel zur�ck gibt. Da das Feld
        /// der Entit�ten hier nicht bekannt ist, muss es als Abstract definiert werden.
        /// </summary>
        /// <returns>Prim�rschl�ssel der Entit�t</returns>
        protected abstract int PrimaryKey();

        #region IEntity Members

        /// <summary>
        /// L�scht das Objekt aus Hibernate / der Datenbank
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
        /// Funktion die Ermittelt, ob die Entit�t bereits gespeichert wurde
        /// </summary>
        public bool IsUnsaved
        {
            get
            {
                return PrimaryKey() == 0;
            }
        }

        #endregion

        #region DataBinding Helper

        public virtual object Instance
        {
            get { return this; }
        }

        #endregion
    }
}
